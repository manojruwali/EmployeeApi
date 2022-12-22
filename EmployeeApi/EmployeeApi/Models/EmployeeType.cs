using System.ComponentModel.DataAnnotations;

namespace EmployeeApi.Models
{
    public class EmployeeType
    {
        [Key]public int EmpTypeId { get; set; }
        public string EmpType { get; set; }
    }
}
