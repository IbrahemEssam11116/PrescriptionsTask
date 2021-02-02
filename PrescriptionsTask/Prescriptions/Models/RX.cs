using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Prescriptions.Models
{
    public class RX
    {
        public int ID { get; set; }
        [ForeignKey("Doctor")]
        public int DoctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
        [ForeignKey("Pation")]
        public int PationID { get; set; }
        public virtual Pation Pation { get; set; }
        [ForeignKey("Clinic")]
        public int ClinicID { get; set; }
        public virtual Clinic Clinic{ get; set; }
        //[DataType(DataType.Date)]
        public DateTime DateFrom { get; set; }
        //[DataType(DataType.Date)]
        public DateTime DateTo{ get; set; }
        public virtual ICollection<RxDetail> RxDetails{ get; set; }
    }
}