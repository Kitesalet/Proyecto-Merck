using System;
using System.Net.Http;
using System.Threading.Tasks;

public class GoogleAnalyticsService
{
    private readonly HttpClient _httpClient;

    public GoogleAnalyticsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task TrackEventAsync(string trackingId, string eventName, string eventCategory, string eventLabel, int age, string selectedOption)
    {
        try
        {
            var parameters = $"v=1&t=event&tid={trackingId}&cid=555&ec={Uri.EscapeDataString(eventCategory)}&ea={Uri.EscapeDataString(eventName)}&el={Uri.EscapeDataString(eventLabel)}&edad={age}&opcion_seleccionada={Uri.EscapeDataString(selectedOption)}";

            var requestUri = $"https://www.google-analytics.com/collect?{parameters}";

            var response = await _httpClient.PostAsync(requestUri, null);

            // Handle the response if needed
            response.EnsureSuccessStatusCode();
        }
        catch (Exception ex)
        {
            // Handle exceptions
            Console.WriteLine($"Error tracking event: {ex.Message}");
        }
    }
}
