using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace Model.Employee
{
     
      public class Employee
    {
        [Required (ErrorMessage="Employee {0} is required")]
        [StringLength (100,MinimumLength=3,
        ErrorMessage="Name Should be minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Range(18,99, ErrorMessage="Age should be between 18 and 99")]
        public int Age { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
    }
    
}
