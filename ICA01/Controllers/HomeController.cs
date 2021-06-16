using ICA01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICA01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private HotelContext context = new HotelContext();
        public ActionResult Index()
        {
            List<Booking> AllBookings = context.Bookings.ToList();
            return View(AllBookings);
        }
        public ActionResult Search()
        {
            List<Booking> AllBookings = context.Bookings.ToList();
            return View(AllBookings);
        }
        [HttpPost]
        public ActionResult Search(String Guestname)
        {
            List<Booking> AllBookings = context.Bookings.Where(x => x.Guest.FirstName.Contains(Guestname)).ToList();
            return View(AllBookings);
        }
        public ActionResult ExtraService(int Id)
        {
            List<Extra> Extras = context.Extras.Where(x => x.BookingId == Id).ToList();
            return View(Extras);
        }
    }
}