using System.ComponentModel.DataAnnotations;

namespace OtelUygulamasi.Models;

public class HotelRoom
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Oda adı zorunludur.")]
    [StringLength(50, ErrorMessage = "Oda adı en fazla 50 karakter olabilir.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Kapasite belirtilmelidir.")]
    [Range(1, 10, ErrorMessage = "Kapasite 1 ile 10 kişi arasında olmalıdır.")]
    public int Occupancy { get; set; } = 1;

    [Required(ErrorMessage = "Fiyat zorunludur.")]
    [Range(100, 100000, ErrorMessage = "Fiyat 100 TL ile 100.000 TL arasında olmalıdır.")]
    public double RegularRate { get; set; } = 1500;

    public string ImageUrl { get; set; } = string.Empty;
}