using System.ComponentModel.DataAnnotations;

namespace OtelUygulamasi.Models;

public class RoomBooking
{
    public int Id { get; set; }
    public int RoomId { get; set; }
    public HotelRoom? Room { get; set; }

    [Required(ErrorMessage = "Ad Soyad girilmelidir.")]
    public string CustomerName { get; set; } = string.Empty;

    [Required(ErrorMessage = "E-posta girilmelidir.")]
    [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
    public string CustomerEmail { get; set; } = string.Empty;

    public DateTime CheckInDate { get; set; } = DateTime.Today;
    public DateTime CheckOutDate { get; set; } = DateTime.Today.AddDays(1);
    public double TotalPrice { get; set; }
    public bool IsPaid { get; set; } = false;
    public bool IsConfirmed { get; set; } = false;
    public bool IsCancelled { get; set; } = false;
    // JSON-encoded list of guest info objects: [{"Name":"...","Tckn":"..."}, ...]
    public string GuestsJson { get; set; } = string.Empty;

    [System.ComponentModel.DataAnnotations.Schema.NotMapped]
    public System.Collections.Generic.List<(string Name, string Tckn)> Guests
    {
        get
        {
            try
            {
                if (string.IsNullOrWhiteSpace(GuestsJson)) return new();
                return System.Text.Json.JsonSerializer.Deserialize<System.Collections.Generic.List<System.Text.Json.JsonElement>>(GuestsJson)?
                    .Select(e => (
                        e.GetProperty("Name").GetString() ?? string.Empty,
                        e.TryGetProperty("Tckn", out var t) ? (t.GetString() ?? string.Empty) : string.Empty
                    )).ToList() ?? new();
            }
            catch
            {
                return new();
            }
        }
    }
}