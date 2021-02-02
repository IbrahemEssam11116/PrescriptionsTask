using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Prescriptions.Models
{
    public class RxDetail
    {
        public int ID { get; set; }
        [ForeignKey("RX")]
        public int RXID { get; set; }
        public virtual RX RX { get; set; }
        [MaxLength(255)]
        public string MedicineName{ get; set; }
        [MaxLength(255)]
        public string Does { get; set; }
    }
}