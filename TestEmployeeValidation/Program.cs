using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Employee;
using System.ComponentModel.DataAnnotations;


namespace TestEmployeeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Employee class Validation");
            Console.WriteLine("---------------------------\n");

            Employee objEmployee = new Employee();
            objEmployee.Name = "sa";
            objEmployee.Age = 12;
            objEmployee.PhoneNumber = "1234as";
            objEmployee.Email = "test@re";


            ValidationContext context = new ValidationContext(objEmployee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(objEmployee, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult vr in results)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Member Name :{0}", vr.MemberNames.First());
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("   ::  {0}{1}", vr.ErrorMessage, Environment.NewLine);

                }

            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
