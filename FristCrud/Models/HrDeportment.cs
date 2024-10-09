using System.ComponentModel.DataAnnotations;

namespace FristCrud.Models
{
    public class HrDeportment
    {
        [Key] 
        public int HrID { get; set; }
        public string ?Name { get; set; }
        public string ?MobileN { get; set; }
        public int Age { get; set; }
        public string ?Salary { get; set; }
    }
}
