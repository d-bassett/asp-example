using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Example.Models
{
    public class App
    {
        [Key]
        public int ID { set; get; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Developer { get; set; }
        public double? Version { get; set; }
    }
}
