using System.ComponentModel.DataAnnotations;

namespace EmployeeApi.Models
{
    public class Employee
    {
        [Key]public int EmpId  { get; set; }
       [Required] public string Name { get; set; }    
        public string Email { get; set; }   
        public string Phone { get; set; }   
        public string Emptype { get; set; }

        public DateTime DOJ { get; set; } = DateTime.Now;
    }
}
