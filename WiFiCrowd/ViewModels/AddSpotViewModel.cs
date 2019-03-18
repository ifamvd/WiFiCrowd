using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WiFiCrowd.ViewModels
{
    public class AddSpotViewModel
    {
        [Display(Name = "Location Name")]
        [Required(ErrorMessage = "You must provide a location name")]
        public string Name { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "You must provide an address")]
        public string Address { get; set; }

        [Display(Name = "Latitude Location")]
        [Required(ErrorMessage = "You must provide the latitude")]
        public string Lat { get; set; }

        [Display(Name = "Longitude Location")]
        [Required(ErrorMessage = "You must provide the longitude")]
        public string Lng { get; set; }

        [Display(Name = "Place URL")]
        [Required(ErrorMessage = "Provide Google Map URL for the establishment")]
        public string Url { get; set; }

        [Display(Name = "WiFi Password")]
        [Required(ErrorMessage = "You must provide the WiFi Password. If no password is required, type 'None'")]
        public string Password { get; set; }

        public AddSpotViewModel() { }
    }
}
