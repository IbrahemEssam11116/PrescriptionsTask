using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prescriptions.Models
{
    public class Doctor
    {
        public int ID { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Specialty { get; set; }
        public virtual ICollection<Clinic> Clinics{ get; set; }
        public virtual ICollection<RX> RXes{ get; set; }

    }
}