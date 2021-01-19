using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dream_carMVC.Models
{
    public class Model
    {
        public int Id { get; set; }// primary key in int datatype
        [Required]//cannot be null
        public string Model_Name { get; set; }//value add in string type data
        [Required]//cannot be null
        public string Model_Year { get; set; }//value add in string type data
        public int Company_Id { get; set; }//value add in string type data
        public Company Company { get; set; }//value add in string type data
        public int DealerId { get; set; }// foreign key in int datatype
        public Dealer Dealer { get; set; }// linking the company table

    }
}
