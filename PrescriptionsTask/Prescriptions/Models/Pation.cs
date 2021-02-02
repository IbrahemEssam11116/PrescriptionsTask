using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prescriptions.Models
{
    public class Pation
    {
        public int ID{ get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        public virtual ICollection<RX> RXes { get; set; }

    }
}