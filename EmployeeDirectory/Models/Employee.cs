using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDirectory.Models
{
    public class Employee
    { 
        [Key]
        public int Id { get; set; }

        [Display (Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }


        public string Country { get; set; }

        [Display(Name = "Date of Birth")]
        public string DateOfBirth { get; set; }

        public int Age { get; set; }

        public string GetFullName()
        {
            if (string.IsNullOrEmpty(LastName))
                throw new MissingFieldException("Last name is empty");

            return string.Format("{0} {1}", FirstName, LastName);
        }
    }



}
