using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class Credit
    {
        [Key]
        public int Faculty_Id { get; set; }
        public int Batch_Id { get; set; }
        public int Feedbackpercentage{ get; set; }
        public int Extrahours { get; set; }
        public int Batchpasspercentage { get; set; }
        public string Facultyupgrade { get; set; }
        public string CertificationDone { get; set; }
        public int Handsoncompletion { get; set; }

    }
}
