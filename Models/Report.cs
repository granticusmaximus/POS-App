using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos_app.Models
{
    public class Report
        {
        [Key]
        public int RID {get;set;}
        public string ReportTitle {get;set;}
    }
}