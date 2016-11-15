using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RaspberryMedbot.Models
{
    public class Patient
    {
        public Patient()
        {
            this.Activities = new HashSet<Activity>();
        }

        [Key]
        public int PatientID { get; set; }
        [ForeignKey("PatientID")]
        public string PatientString { get { return (FirstName + " " + LastName); } }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Birthday { get; set; }

        public virtual ICollection<Activity> Activities { get; set; }
    }
}