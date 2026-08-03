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
}