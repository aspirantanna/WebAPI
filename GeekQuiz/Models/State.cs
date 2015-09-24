using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeekQuiz.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Newtonsoft.Json;

    public class State
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string StateName{ get; set; }
    }
}