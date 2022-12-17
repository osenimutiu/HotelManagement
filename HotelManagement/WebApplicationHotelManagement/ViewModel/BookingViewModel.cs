using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationHotelManagement.ViewModel
{
    public class BookingViewModel
    {

        public int BookingId { get; set; }


        [Display(Name = "Customer Name")]
        [Required (ErrorMessage = "Customer Name required")]
        public string CustomerName { get; set; }

        [Display(Name = "Customer Address")]
        [Required(ErrorMessage = "Customer Address required")]
        public string CustomerAddress { get; set; }

        [Display(Name = "Customer Phone")]
        [Required(ErrorMessage = "Customer Phone required")]
        public string CustomerPhone { get; set; }

        [Display(Name = "Booking From")]
        [Required(ErrorMessage = "Booking From required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BookingFrom { get; set; }

        [Display(Name = "Booking To")]
        [Required(ErrorMessage = "Booking To required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BookingTo { get; set; }

        [Display(Name = "Assign Room")]
        [Required(ErrorMessage = "Assign Room required")]
        public int AssignRoomId { get; set; }

        [Display(Name = "Number Of Members")]
        [Required(ErrorMessage = "Number Of Members required")]
        public int NoOfMembers { get; set; }
          
        public IEnumerable<SelectListItem> ListOfRooms { get; set; }

    }
}