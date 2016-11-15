using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RaspberryMedbot.Models
{
    public class Activity
    {
        [Key]
        public int ActivityID { get; set; }
        public int PatientID { get; set; }
        public bool? Response { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? ResponseTime { get; set; }

        public virtual Patient Patient { get; set; }
    }
}