namespace UpCount
{
    public class Expense
    {

        public double Amount { get; set; }
        public string Date { get; set; }
        public string Currency { get; set; }
        public string Category { get; set; }

        public Expense(double amount, string date, string currency, string category)
        {
            Amount = amount;
            Date = date;
            Currency = currency;
            Category = category;
        }
    }
}
