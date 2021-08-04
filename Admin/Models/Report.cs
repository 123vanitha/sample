using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class Report
    {
        [Key]
        public int Faculty_Id { get; set; }
        public int Batch_code { get; set; }
    }
}
