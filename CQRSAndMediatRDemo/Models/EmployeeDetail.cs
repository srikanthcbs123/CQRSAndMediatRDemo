using System.ComponentModel.DataAnnotations;

namespace CQRSAndMediatRDemo.Models
{
    public class EmployeeDetail
    {
        [Key]
        public string employeeid {  get; set; }
        public string employeename { get; set; }
        public string employeesalary { get; set; }
    }
}
