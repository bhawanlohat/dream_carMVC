using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dream_carMVC.Models
{
    public class Specification
    {
        public int Id { get; set; }// primary key in int datatype
        [Required]//cannot be null
        public string Fuel_type { get; set; }//value add in string type data
        [Required]//cannot be null
        public string Transmission { get; set; }//value add in string type data
        [Required]//cannot be null
        public string GPS { get; set; }//value add in string type data
        [Required]//cannot be null
        public string Rating { get; set; }//value add in string type data
        public int ModelId { get; set; }//foreign key in int datatype
        public Model Model { get; set; }//linking the company table

    }
}
