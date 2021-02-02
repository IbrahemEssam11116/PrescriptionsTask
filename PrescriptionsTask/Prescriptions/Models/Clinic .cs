using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Prescriptions.Models
{
    public class Clinic
    {
        
        public int ID { get; set; }
        [MaxLength(255)]
        public string Address { get; set; }
        [MaxLength(20)]
        public string Mobile { get; set; }
        [ForeignKey("Doctor")]
        public int DoctorID { get; set; }
        public virtual Doctor Doctor{ get; set; }
        public virtual ICollection<RX> RXes { get; set; }

    }
}