using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dream_carMVC.Models
{
    public class Company
    {
        public int Id { get; set; }// primary key in int datatype
        [Required]//cannot be null
        public string Company_Name { get; set; }//value add in string type data
        [Required]//cannot be null
        public string Company_Website { get; set; }//value add in string type data
        public string Company_Phone { get; set; }//value add in string type data
        public string Company_Email { get; set; }//value add in string type data
        public string Company_Headquater { get; set; }//value add in string type data
    }
}
