using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMvcCurdApp.Models
{
    public class Emloyee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address  { get; set; }
        [Required]
        public DateTime Dob { get; set; }


    }
}
