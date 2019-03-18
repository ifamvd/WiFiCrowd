using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WiFiCrowd.Data;
using WiFiCrowd.Models;
using WiFiCrowd.ViewModels;

namespace WiFiCrowd.Controllers
{
    public class HomeController : Controller
    {
        // database stuff
        private MarkerDbContext context;
        public HomeController(MarkerDbContext dbContext)
        {
            context = dbContext;
        }

        // GET:
        public IActionResult Index()
        {
            ViewBag.Title = "WiFi Crowd";
            IList<Marker> markers = context.Markers.ToList();
            return View(markers);
        }

        // GET:
        public IActionResult AddSpot()
        {
            ViewBag.Title = "Add A New Spot";
            AddSpotViewModel addSpotViewModel = new AddSpotViewModel();
            return View(addSpotViewModel);
        }

        // POST:
        [HttpPost]
        public IActionResult AddSpot(AddSpotViewModel addSpotViewModel)
        {
            ViewBag.Title = "Add A New Spot";
            if (ModelState.IsValid)
            {
                // Add New Location to the database
                Marker newMarker = new Marker
                {
                    Name = addSpotViewModel.Name,
                    Address = addSpotViewModel.Address,
                    Lat = addSpotViewModel.Lat,
                    Lng = addSpotViewModel.Lng,
                    Url = addSpotViewModel.Url,
                    Password = addSpotViewModel.Password
                };
                context.Markers.Add(newMarker);
                context.SaveChanges();
                return Redirect("/Home");
            }
            return View(addSpotViewModel);
        }

        // GET:
        public IActionResult RemoveSpot()
        {
            ViewBag.title = "Remove Spots";
            ViewBag.markers = context.Markers.ToList();
            return View();
        }

        // POST:
        [HttpPost]
        public IActionResult RemoveSpot(int[] markerIds)
        {
            foreach (int markerId in markerIds)
            {
                Marker theCheese = context.Markers.Single(s => s.ID == markerId);
                context.Markers.Remove(theCheese);
            }
            context.SaveChanges();
            return Redirect("/Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
