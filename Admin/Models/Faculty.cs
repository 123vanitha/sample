using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class Faculty
    {
        [Key]
        public int Faculty_Id { get; set; }
        public string Faculty_Name { get; set; }
        public string Highest_Qualification { get; set; }
        public int YearofExperiance { get; set; }
        public int Contact { get; set; }
        public string FacultyEmail { get; set; }
        public string Street_Address { get; set; }

    }
}
