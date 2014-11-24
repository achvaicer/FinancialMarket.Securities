namespace FinancialMarket.Securities
{
    public abstract class Security
    {
        private Bloomberg _bloomberg;

        public string Name { get; set; }
        public string Description { get; set; }

        #region Identifiers

        public string Sedol { get; set; }
        public string Isin { get; set; }
        public string Cusip { get; set; }

        public string BloombergGlobalID
        {
            get { return Bloomberg.GlobalID; }
            set { Bloomberg.GlobalID = value; }
        }

        #endregion

        public Bloomberg Bloomberg
        {
            get { return _bloomberg ?? (_bloomberg = new Bloomberg()); }
            set { _bloomberg = value; }
        }
    }
}
