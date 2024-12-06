namespace CurrencyConverter.Models
{
    public class CurrencyConverterModel
    {
        public decimal Amount { get; set; }
        public string OriginCurrency { get; set; } = "Select Currency";
        public string DestinationCurrency { get; set; } = "Select Currency";
        public decimal Result { get; set; }
    }
}