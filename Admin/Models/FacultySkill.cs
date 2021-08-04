using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class FacultySkill
    {
        [Key]
        public int Faculty_Id { get; set; }
        public string Facultyskill { get; set; }
        public string Facultyskill1 { get; set; }
        public string Facultyskill2 { get; set; }
        public string CertificateTitle { get; set; }
    }
}
