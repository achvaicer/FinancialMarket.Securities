using System;

namespace FinancialMarket.Securities
{
    public abstract class CurrencyForward : ForeignExchange, IDerivative
    {
        public decimal NotionalAmount { get; set; }
        public DateTime FixingDate { get; set; }
        public decimal ContractedRate { get; set; }
        public decimal FixingSpotDate { get; set; }
    }
}
