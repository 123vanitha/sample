using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class Batch
    {
        [Key]
        public int Faculty_Id { get; set; }
        public int Domain_Id { get; set; }
        public int Batchstartdate { get; set; }
        public int Batchenddate { get; set; }
    }
}
