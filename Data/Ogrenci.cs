using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Models
{
    public class Ogrenci
    {
        [Key]
        public int OgrenciId { get; set; }
        public string? OgreniAd { get; set; }
        public string? OgrenciSoyad { get; set; }
        public string? Eposta { get; set; }
        public string? telefon { get; set; }


    }
}