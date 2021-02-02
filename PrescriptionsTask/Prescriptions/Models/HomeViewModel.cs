using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prescriptions.Models
{
    [NotMapped]
    public class HomeViewModel
    {
        public SelectList DoctorList { get; set; }
        //[DataType(DataType.Date)]
        [Display(Name = "Doctor")]
        public int ?DoctorID { get; set; }
        [Display(Name = "Date From")]
        public DateTime ?DateFrom { get; set; }
        //[DataType(DataType.Date)]
        [Display(Name = "Date To")]
        public DateTime? DateTO { get; set; }
        [Display(Name = "Pation Name or Phone")]
        public string PationData { get; set; }
        public ICollection<RX> RX{ get; set; }
        public HomeViewModel()
        {
            RX = new Collection<RX>();
        }

    }
}