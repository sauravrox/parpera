namespace Parpera.HelperClass
{
    public class Transaction
    {
        public int ID { get; set; }
        public DateTime Datetime { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
    
    }

    public class UpdateStatusInput
    {
        public string Status { get; set; }
    }
}
