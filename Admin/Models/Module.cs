using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class Module
    {
        [Key]
        public int Faculty_Id { get; set; }
        public String Technology_Name { get; set; }
        public String Domain_Description { get; set; }
        public string Module_Type { get; set; }
        public int Duration { get; set; }

    }
}
