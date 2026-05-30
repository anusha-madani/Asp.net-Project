using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherDashboard.Models;

namespace WeatherDashboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey = "e9e2e1f761082a2d3a86a39366c7c4ca"; 

        public HomeController()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IActionResult> Index(string city = "Karachi")
        {
            if (string.IsNullOrEmpty(city)) city = "Karachi";

            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric";

            try
            {
                var response = await _httpClient.GetAsync(url);
                var jsonString = await response.Content.ReadAsStringAsync();
                
                if (response.IsSuccessStatusCode)
                {
                    var weatherData = JsonSerializer.Deserialize<WeatherViewModel>(jsonString);
                    return View(weatherData);
                }
                
                   if (response.StatusCode == System.Net.HttpStatusCode.NotFound || jsonString.Contains("city not found"))                {
                    ViewBag.Error = "Wrong city name! Please enter a correct city name.";
                }
                else
                {
                    ViewBag.Error = "Something went wrong. Please try again later.";
                }
                
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Error = $"System Error: {ex.Message}";
                return View();
            }
        }
    }
}