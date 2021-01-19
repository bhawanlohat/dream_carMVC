using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dream_carMVC.Models
{
    public class Dealer
    {
        public int Id { get; set; }// primary key in int datatype
        [Required]
        public string Dealer_Name { get; set; }//value add in string type data
        public string Dealer_Website { get; set; }//value add in string type data
        [Required]// cannot be null
        public string Dealer_Address { get; set; }//value add in string type data

        public string Dealer_Email { get; set; }//value add in string type data
        public int CompanyId { get; set; }// foreign key in int datatype
        public Company Company { get; set; }// linking the company table

    }
}
