using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FloChar.Models
{
    public class Answer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int QuestionId { get; set; }
        
        public bool Value { get; set; }
        [MaxLength(767)]
        public string UserId { get; set; }
    }
}
