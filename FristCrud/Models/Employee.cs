
using System.ComponentModel.DataAnnotations;

namespace FristCrud.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string ?Name { get; set; }
        public int Age { get; set; }

        public string ?MobileN { get; set; }
        public string ?Salary { get; set; }
    }
}
