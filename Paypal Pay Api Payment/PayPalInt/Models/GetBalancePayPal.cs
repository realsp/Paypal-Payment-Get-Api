using System;

namespace PayPalInt
{
    public class GetBalancePayPal
    {
                
    }

    public class balance
    {
        public string currency { get; set; }
        public Boolean primary { get;; set; }
        public total_balance_object total_balance { get; set; }
    }

    public class total_balance_object
    {
        public string currency_code
    }
}

