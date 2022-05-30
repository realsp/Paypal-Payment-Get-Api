using PayPalInt.Models.Balance;

namespace PayPalInt.Interfaces
{
    public interface PayPalInterface
    {
        public Balance GetPayPalBalance(string as_of_time, string currency_code, string last_refresh_time);
    }
}
