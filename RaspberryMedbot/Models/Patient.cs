using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RaspberryMedbot.Models
{
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private DateTime birthday;
        public DateTime Birthday
        {
            get
            {
                return this.birthday.Date;
            }
            set
            {
                this.birthday = value;
            }
        }
        
    }
}