# Author: Robert Geraghty

import operator
from collections import Counter
import math
import csv
import pprint
import argparse
import time
import random
import networkx as nx
import matplotlib.pyplot as plt
from networkx.drawing.nx_agraph import to_agraph, write_dot, graphviz_layout
import json


# handle args
parser = argparse.ArgumentParser()
parser.add_argument('-p', '--positive', nargs=1, required = True, help='Type the symbol you that denotes a positive label in the .csv')
parser.add_argument('-f', '--file', nargs=1, required = True, help='The .csv file to read data from. Data must have binary classifications. '
+'Top row must be attribute titles, and last column must be the classifications')
parser.add_argument('-g', '--gini', required=False, action='store_true', help=
    'If this flag is used then at the gini will be used instead of entropy')
parser.add_argument('-t', '--training_proportion', nargs=1, required = True, help='the proportion of the file to be used as training data')
parser.add_argument('--test', required = False, action='store_true', help='Test 20 different training set sizes and print thier accuracy')
args = parser.parse_args()

postive_symbol = args.positive[0]
data_file = args.file[0]
gini_true = args.gini
train_prop = float(args.training_proportion[0])
run_test = args.test

# Holds decision tree data and methods
class Decision_Tree_Learner:
    def __init__(self):
        pass

    # decision tree learning algorithm
    def learn(self, examples, attributes, parent_examples, gini = False):
        # End conditions
        if len(examples) == 0:
            return self.plurality_value(parent_examples)

        elif self.same_class_check(examples):
            return examples[0].classification

        elif len(attributes) == 0:
            return self.plurality_value(examples)
        # else pick the most important attribute and recurse
        else:
            A = max(self.importance(attributes, examples, gini_true).items(), key=operator.itemgetter(1))[0]
            tree = Decision_Tree(A)
            for vk in A.values:
                exs = [e for e in examples if e.attribute_values[A] == vk]
                subtree = self.learn(exs, [a for a in attributes if a != A], examples)
                tree.branches.append(Decision_Branch(vk, subtree))
            return tree
    # return the gain with eith entropy or gini
    def importance(self, attributes, examples, gini = False):
        return self.gain(attributes, examples, gini)
        
    # calculate the information gain
    def gain(self, attributes, examples, gini=False):
        gain_dict = {}
        for A in attributes:
            classes = [ex.classification for ex in examples]
            p = classes.count(1)
            n = len(classes) - p
            gain_dict[A] = self.impurity_entropy(p/(p+n), gini) - self.remainder(A, examples, gini)
        return gain_dict
    # return either gini impurity or entropy
    def impurity_entropy(self, q, gini):
        if gini:
            return (q)*(1-q)
        if(q == 0 or q == 1):
            return 0
        return -(q*math.log(q, 2) + (1-q)*math.log(1-q, 2))
    # compute remaining impurity or entropys
    def remainder(self, attribute, examples, gini):
        sum = 0
        classes = [ex.classification for ex in examples]
        p = classes.count(1)
        n = len(classes) - p
        for vk in attribute.values:
            classes_k = [ex.classification for ex in examples if ex.attribute_values[attribute] == vk]
            pk = classes_k.count(1)
            nk = len(classes_k) - pk
            denom = pk+nk
            if denom == 0:
                sum += (pk+nk)/(p+n) * self.impurity_entropy(0, gini)
            else:
                sum += (pk+nk)/(p+n) * self.impurity_entropy(pk/denom, gini)
        return sum
    # check if all examples have to same classification
    def same_class_check(self, examples):
        for ex in examples:
            if ex.classification != examples[0].classification:
                return False
        return True
    # get the most common value
    def plurality_value(self, examples):
        if len(examples) == 0:
            return 1
        counts = Counter([ex.classification for ex in examples])
        return max(counts.items(), key=operator.itemgetter(1))[0]

# Holds decision tree data and methods
class Decision_Tree:
    def __init__(self, root):
        self.root = root
        self.branches = []
    
    #used for classifying test data
    def evaluate(self, example):
        if (self.root == 1 or self.root == 0):
            return self.root == example.classification
        
        vk = example.attribute_values[self.root]
        b = [branch for branch in self.branches if branch.label == vk][0]
        return b.evaluate(example)

    def create_networkx(self, network = None):
        net = None
        if network == None:
            net = nx.DiGraph()
        else:
            net = network
        if self.root == 1:
            net.add_node('Yes', color = 'black')
        elif self.root == 0:
            net.add_node('No', color = 'black')
        else:
            net.add_node(self.root.name, color = "black")

        for branch in self.branches:
            branch.create_networkx(net, self.root.name)
        
        return net

    # used for print the tree in a readable way
    def print(self, depth):
        tab_string = ''
        for i in range(0, depth):
            tab_string += "\t"
        print(tab_string + str(self.root))
        maxdepth = depth
        for b in self.branches:
            maxdepth = max(maxdepth,b.print(depth+1))
        return maxdepth

# Represents a branch on a decision tree
class Decision_Branch:
    def __init__(self, label, subtree):
        self.label = label
        self.subtree = subtree

    #used for classifying test data
    def evaluate(self, example):
        if (self.subtree == 1 or self.subtree == 0):
            return self.subtree == example.classification
        return self.subtree.evaluate(example)

    def create_networkx(self, network, parent_name):
        if type(self.subtree) != Decision_Tree:
            name = 'No'
            if self.subtree == 1:
                name = 'Yes'
            network.add_node(name, color = "black")
            network.add_edge(parent_name, name, label = self.label)
        else:
            self.subtree.create_networkx(network)
            network.add_edge(parent_name, self.subtree.root.name, label = self.label)

    # used for print the tree in a readable way
    def print(self, depth):
        tab_string = ''
        maxdepth = depth
        for i in range(0, depth-1):
            tab_string += "\t"
        print(tab_string+' >'+self.label)
        try:
            maxdepth=max(maxdepth,self.subtree.print(depth))
        except:
            print(tab_string+"\t"+str(self.subtree))
            return depth+1
        return maxdepth

#holds the attribule values and classification of a specific instances
class Example:
    def __init__(self, attribute_values, classification):
        self.attribute_values = attribute_values
        self.classification = classification
    #  string form of this class object
    def __str__(self):
        return {'Attributes': self.attribute_values, 'Classification': self.classification}

# holds an attribute and its possible values
class Attribute:
    def __init__(self, name, values):
        self.name = name
        self.values = values

    def add_value(self, value):
        if value not in self.values:
            self.values.append(value)
    
    def __str__(self):
        return "{Name: "+ str(self.name) + ", values: "+ str(self.values) + "}"
    

def main():
    # Read in file
    with open(data_file) as csvfile:
        data_reader = csv.reader(csvfile, delimiter=',')
        line_count = -1
        header = []
        attributes = []
        examples = []
        for row in data_reader:
            if line_count == -1:
                header = row
                # init attributes
                attributes = make_attributes_from_csv_header(header)
                line_count += 1
            else:
                # update attributes with any new values and create new example
                attributes = update_attributes_from_csv_row(row, attributes)
                examples.append(make_example_from_csv_row(row, attributes))
        # shuffle for randomnesss
        random.shuffle(examples)
        
        # if run test than run test ranging from 0.05 to 0.95 of the data being trained on
        if run_test:
            proportions = []
            for i in range(1, 20):
                training_cuttoff = int(len(examples)*(i/20))
                
                
                training_set = examples[0:training_cuttoff]
                testing_set = examples[training_cuttoff:-1]

                # init learner and learn the data
                DTL = Decision_Tree_Learner()
                time_start = time.time()
                tree = DTL.learn(training_set, attributes, [], gini_true)
                total_time = time.time() - time_start
                # depth = tree.print(0)

                correct_count = 0
                for j in testing_set:
                    if tree == 0 or tree == 1:
                        if j.classification == tree:
                            correct_count += 1
                    elif tree.evaluate(j):
                        correct_count += 1
                #  print stats
                print(str(i/20)+"," + str(training_cuttoff) + "," + str(correct_count/len(testing_set)))
        else:
            # if not test just run one training and testing cycles
            training_cuttoff = int(len(examples)*(train_prop))
            
            
            training_set = examples[0:training_cuttoff]
            testing_set = examples[training_cuttoff:-1]

            DTL = Decision_Tree_Learner()
            time_start = time.time()
            tree = DTL.learn(training_set, attributes, [], gini_true)
            total_time = time.time() - time_start
            if (type(tree) != int):
                depth = tree.print(0)

            if train_prop != 1:
                correct_count = 0
                for j in testing_set:
                    if tree == 0 or tree == 1:
                        if j.classification == tree:
                            correct_count += 1
                    elif tree.evaluate(j):
                        correct_count += 1
                print(str(train_prop)+"," + str(training_cuttoff) + "," + str(correct_count/len(testing_set)))

            net = tree.create_networkx()
            # write_dot(net, "test.dot")
            A = to_agraph(net)
            args = ''
            A.layout('dot', args=args +'-Gsplines=spline -Glabel="Should I wait for a table at a restaurant?"')
            A.draw('test2.png')
            

        # print(depth)
    
#  read in header into attributes objectss
def make_attributes_from_csv_header(header):
    attributes = []
    for i in range(0, len(header)-1):
        attributes.append(Attribute(header[i], []))
    return attributes
# add new found attribute values to the attributes
def update_attributes_from_csv_row(row, attributes):
    for i in range(0, len(row)-1):
        attributes[i].add_value(row[i])
    return attributes
# create new example from csv row
def make_example_from_csv_row(row, attributes):
    attribute_values = {}
    for i in range(0, len(row)-1):
        attribute_values[attributes[i]] = row[i]
    c = 0
    # print(len(row))
    if (row[-1] == postive_symbol):
        c = 1
    return Example(attribute_values, c)




class Bayes_Net():
    def __init__(self):
        self.net = nx.DiGraph()
        self.nodes = []

    def create_from_json(self, file):
        with open(file) as json_file:
            data = json.load(json_file)
            for name, value in data.items():
                node = Bayes_Node(str(name), [str(i) for i in value['parents']], value['prob'])
                self.nodes.append(node)
                self.net.add_node(node.name, cpt = node.cpt, color='black')
                for parent in node.parents:
                    self.net.add_edge(parent, node.name, label=(parent+"->"+node.name), color='black')#, minlen=(abs(int(parent)-int(node.name))*1))
            
    def add_node(self, node):
        self.net.add_node(node.name, cpt = node.cpt)
        for parent in node.parents:
            self.net.add_edge(parent.name, node.name)

    def draw(self):
        # nx.draw_graphviz(self.net, with_labels=True)
        # print(nx.get_node_attributes(self.net, 'cpt'))
        # write_dot(self.net, "test.dot")
        A = to_agraph(self.net)
        args = ''
        if nx.algorithms.tree.recognition.is_forest(self.net):
            A.layout('dot', args='-Efontsize=10 -Efontcolor=red -Gsplines=spline')
        else:
            A.layout('dot', args=args +'-Elabelstyle=invis -Gsplines=ortho ')
        A.draw('test2.png')
        # pos = graphviz_layout(self.net,prog='dot', args='')    
        # nx.draw(self.net, pos, splines='spline', with_labels=True, font_size=12, node_size=200, node_color ="white", node_border='black', edge_color="black")
        # plt.show()

class Bayes_Node():
    def __init__(self, name, parents, cpt):
        self.name = name 
        self.parents = parents
        self.cpt = cpt


if __name__ == "__main__":
    main()