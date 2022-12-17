using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationHotelManagement.ViewModel
{
    public class RoomDetailsViewModel
    {

        public int RoomId { get; set; }

        [Display(Name = "Room Number")]
        public string RoomNumber { get; set; }

        [Display(Name = "Room Image")]
        public string RoomImage { get; set; }

        [Display(Name = "Room Price")]
        public decimal RoomPrice { get; set; }

        [Display(Name = "Booking Status")]
        public string BookingStatus { get; set; }

        [Display(Name = "Room Type")]
        public string RoomType { get; set; }

        [Display(Name = "Room Capacity")]
        public int RoomCapacity { get; set; }

        public HttpPostedFileBase Image { get; set; }

        [Display(Name = "Room Description")]
        public string RoomDescription { get; set; }
    }
}