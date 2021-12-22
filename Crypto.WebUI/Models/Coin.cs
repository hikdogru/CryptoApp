namespace Crypto.WebUI.Models
{
    public class Coin
    {
        public string Market { get; set; }
        public double Price { get; set; }
        public double High24Hour { get; set; }
        public double Low24Hour { get; set; }
        public double Volume24Hour { get; set; }
        public double Change24Hour { get; set; }
    }
}
