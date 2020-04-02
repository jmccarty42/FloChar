using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace FloChar.Pages
{
    public class treedisplayModel : PageModel
    {
        [BindProperty]
        public string jsonData { get; set; }

        public void OnGet()
        {
            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //startInfo.FileName = "python";
            //startInfo.Arguments = "wwwroot/lib/dtl_algorithm/DecisionTree.py -f wwwroot/lib/dtl_algorithm/treeData.json";
            //process.StartInfo = startInfo;
            //process.Start();
            //
            //String command = @"python wwwroot/lib/dtl_algorithm/DecisionTree.py -f wwwroot/lib/dtl_algorithm/test_data.csv -o wwwroot/lib/dtl_algorithm/treeData.json";
            //ProcessStartInfo cmdsi = new ProcessStartInfo("cmd.exe");
            //cmdsi.Arguments = command;
            //Process cmd = Process.Start(cmdsi);
            //cmd.WaitForExit();

            //string strCmdText;
            //strCmdText = "wwwroot/lib/dtl_algorithm/DecisionTree.py -f wwwroot/lib/dtl_algorithm/test_data.csv -o wwwroot/lib/dtl_algorithm/treeData.json";
            //System.Diagnostics.Process.Start("python", strCmdText);

            //jsonData = System.IO.File.ReadAllText(@"Pages/treeData.json");
        }
    }
}