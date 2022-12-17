using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationHotelManagement.ViewModel
{
    public class RoomBookingViewModel
    {
        public int BookingId { get; set; }


        [Display(Name = "Customer Name")]
        [Required(ErrorMessage = "Customer Name required")]
        public string CustomerName { get; set; }

        [Display(Name = "Number Of Members")]
        [Required(ErrorMessage = "Number Of Members required")]
        public int NumberOfMembers { get; set; }

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

        [Display(Name = "Room Number")]
        public string RoomNumber { get; set; }

        [Display(Name = "Room Price")]
        public decimal RoomPrice { get; set; }

        [Display(Name = "Number Of Days")]
        public int NumberOfDays { get; set; }

        [Display(Name = "Total Amount")]
        public decimal? TotalAmount { get; set; }

        



    }
}