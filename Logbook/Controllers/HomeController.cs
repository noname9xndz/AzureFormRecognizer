using Geocoding;
using Geocoding.Google;
using Logbook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Logbook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var lat = 21.01143;
            var lng = 105.77555;
            //https://maps.googleapis.com/maps/api/directions/json?origin=Disneyland&destination=Universal+Studios+Hollywood&key=YOUR_API_KEY
            //IGeocoder geocoder = new GoogleGeocoder() { ApiKey = "AIzaSyA65gRrNVTRBciwFzQ60NGN4d2-NMM1M1A" };

            //IEnumerable<Address> addresses = await geocoder.ReverseGeocodeAsync(new Location(lat, lng));
            //var result = await geocoder.GeocodeAsync("New York, New York");
            //Console.WriteLine("Formatted: " + addresses.First().FormattedAddress);
            //// Formatted: 1600 Pennsylvania Ave SE, Washington, DC 20003, USA

            //Console.WriteLine("Coordinates: " + addresses.First().Coordinates.Latitude + ", " + addresses.First().Coordinates.Longitude);
            return View();
        }

        public IActionResult GoogleMap()
        {
            //GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

            //// Do not suppress prompt, and wait 1000 milliseconds to start.
            //watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

            //GeoCoordinate coord = watcher.Position.Location;

            //if (coord.IsUnknown != true)
            //{
            //	Console.WriteLine("Lat: {0}, Long: {1}",
            //		coord.Latitude,
            //		coord.Longitude);
            //}
            //else
            //{
            //	Console.WriteLine("Unknown latitude and longitude.");
            //}
            return View();
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

        //[Collection("Settings")]
        //public class GoogleAsyncGeocoderTest : AsyncGeocoderTest
        //{
        //	GoogleGeocoder geoCoder;

        //	protected override IGeocoder CreateAsyncGeocoder()
        //	{
        //		string apiKey = settings.GoogleApiKey;

        //		if (String.IsNullOrEmpty(apiKey))
        //		{
        //			geoCoder = new GoogleGeocoder();
        //		}
        //		else
        //		{
        //			geoCoder = new GoogleGeocoder(apiKey);
        //		}

        //		return geoCoder;
        //	}

        //	[Theory]
        //	[InlineData("United States", GoogleAddressType.Country)]
        //	[InlineData("Illinois, US", GoogleAddressType.AdministrativeAreaLevel1)]
        //	[InlineData("New York, New York", GoogleAddressType.Locality)]
        //	[InlineData("90210, US", GoogleAddressType.PostalCode)]
        //	[InlineData("1600 pennsylvania ave washington dc", GoogleAddressType.Establishment)]
        //	public async Task CanParseAddressTypes(string address, GoogleAddressType type)
        //	{
        //		var result = await geoCoder.GeocodeAsync(address);
        //		GoogleAddress[] addresses = result.ToArray();
        //		Assert.Equal(type, addresses[0].Type);
        //	}
        //}
    }
}