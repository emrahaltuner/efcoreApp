namespace efcoreApp.Models
{
    public class KursKayit
    {
        public int KursKayitId { get; set; }
        public int OgrenciId { get; set; }
        public int KursId { get; set; }
        public DateTime KursKayitTarihi { get; set; }
    }
}