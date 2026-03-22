using Microsoft.AspNetCore.Mvc;
using HotelBookingApp.Models;
using System.Collections.Generic;

namespace HotelBookingApp.Controllers
{
    public class RoomsController : Controller
    {
        public static List<Room> rooms = new List<Room>()
        {
            new Room
            {
                Id = 1,
                RoomNumber = "101",
                Type = "Deluxe",
                Price = 3000,
                ImageUrl = "https://images.pexels.com/photos/271624/pexels-photo-271624.jpeg"
            },
            new Room
            {
                Id = 2,
                RoomNumber = "102",
                Type = "Suite",
                Price = 5000,
                ImageUrl = "https://images.pexels.com/photos/164595/pexels-photo-164595.jpeg"
            },

            // ✅ NEW ROOMS
            new Room
            {
                Id = 3,
                RoomNumber = "103",
                Type = "Luxury",
                Price = 8000,
                ImageUrl = "https://images.pexels.com/photos/261102/pexels-photo-261102.jpeg"
            },
            new Room
            {
                Id = 4,
                RoomNumber = "104",
                Type = "Standard",
                Price = 2000,
                ImageUrl = "https://images.pexels.com/photos/271618/pexels-photo-271618.jpeg"
            },
            new Room
            {
                Id = 5,
                RoomNumber = "105",
                Type = "Family",
                Price = 6000,
                ImageUrl = "https://images.pexels.com/photos/1648776/pexels-photo-1648776.jpeg"
            },
            new Room
            {
                Id = 6,
                RoomNumber = "106",
                Type = "Executive",
                Price = 7000,
                ImageUrl = "https://images.pexels.com/photos/1457842/pexels-photo-1457842.jpeg"
            }
        };

        public IActionResult Index()
        {
            return View(rooms);
        }
    }
}