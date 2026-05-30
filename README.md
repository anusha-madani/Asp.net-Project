🌤️ SkySnap – Aesthetic Weather Dashboard

SkySnap is a modern, responsive, and beautifully designed Weather Dashboard built using **ASP.NET Core MVC**. It utilizes the **OpenWeatherMap API** to fetch real-time weather details and features a dynamic **Glassmorphic UI** that automatically changes its theme/background based on the current weather condition of the searched city.

---

✨ Features

- Real-Time Data:** Fetches live temperature, feels-like temperature, humidity, and wind speed directly from OpenWeatherMap.
- Dynamic Weather Themes:** The background gradient shifts dynamically (e.g., Warm Sunset colors for 'Clear' sky, Deep Stormy shades for 'Thunderstorms', and Matte Gray-Blue for 'Clouds').
- User-Friendly Error Handling:** Clean and understandable alerts for common issues like misspelled or wrong city names instead of raw API errors.
- Responsive Layout:** Built with Bootstrap and customized CSS transitions for a fluid experience across desktop and mobile screens.
- Modern UI Touch:** Fully implemented Frosted Glass (Glassmorphism) effect with drop-shadowed weather icons.

---

🛠️ Tech Stack & Tools

- Backend: .NET 8.0 / ASP.NET Core MVC
- Frontend: Razor Views, HTML5, CSS3, Bootstrap 5
- API Integration: `HttpClient` with asynchronous `JSON` Deserialization
- Data Source: OpenWeatherMap API

---

🚀 How to Run Locally

1. Prerequisites
Make sure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed on your system.

2. Clone the Repository
```bash
git clone [https://github.com/anusha-madani/Asp.Net-Project.git](https://github.com/anusha-madani/Asp.Net-Project.git)
cd SkySnap
