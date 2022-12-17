using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationHotelManagement.ViewModel
{
    public class RoomViewModel
    {

        public int RoomId { get; set; }

        [Display(Name= "Room Number")]
        [Required(ErrorMessage = "Room Number required")]
        public string RoomNumber { get; set; }

        [Display(Name = "Room Image")]
        [Required(ErrorMessage = "Room Image required")]
        public string RoomImage { get; set; }

        [Display(Name = "Room Price")]
        [Required(ErrorMessage = "Room Price required")]
        [Range(500, 1000, ErrorMessage = "Room price must be greater than or equal to {1}")]
        public decimal RoomPrice { get; set; }

        [Display(Name = "Booking Status")]
        [Required(ErrorMessage = "Booking Status required")]
        public int BookingStatusId { get; set; }

        [Display(Name = "Room Type")]
        [Required(ErrorMessage = "Room Type required")]
        public int RoomTypeId { get; set; }

        [Display(Name = "Room Capacity")]
        [Required(ErrorMessage = "Room Capacity required")]
        [Range(1, 8, ErrorMessage = "Room capacity must be greater than or equal to {1}")]
        public int RoomCapacity { get; set; }

        public HttpPostedFileBase Image { get; set; }

        [Display(Name = "Room Description")]
        [Required(ErrorMessage = "Room Description required")]
        public string RoomDescription { get; set; }
        public List<SelectListItem> ListOfBookingStatus { get; set; }
        public List<SelectListItem> ListOfRoomType { get; set; }

    }
}