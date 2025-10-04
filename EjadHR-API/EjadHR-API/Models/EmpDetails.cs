using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EjadHR_API.Models
{
    public class EmpDetails
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; } = "";

        [Column(TypeName = "nvarchar(250)")]
        public string Email { get; set; } = "";

        [Column(TypeName = "nvarchar(250)")]
        public string Phone { get; set; } = "";

        [Column(TypeName = "nvarchar(250)")]
        public string Linkedin { get; set; } = "";

        [Column(TypeName = "nvarchar(250)")]
        public string JobTitle { get; set; } = "";

        [Column(TypeName = "nvarchar(250)")]
        public string CompanyName { get; set; } = "";

        [Column(TypeName = "date")]
        public DateTime? CompanyFrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CompanyTo { get; set; }

        [Column(TypeName = "int")]
        public int Salary { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string CourseName { get; set; } = "";

        [Column(TypeName = "nvarchar(250)")]
        public string CourseCenter { get; set; } = "";

        [Column(TypeName = "date")]
        public DateTime? CourseFrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CourseTo { get; set; }

    


        [Column(TypeName = "nvarchar(250)")]
        public string Language { get; set; } = "";
    }

}
