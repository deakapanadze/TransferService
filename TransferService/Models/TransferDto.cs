namespace TransferServiceWebAPI.Models
{
    public class TransferDto
    {
        public Guid Id { get; set; }
        public string SourceAccountNumber { get; set; }
        public string DestinationAccountNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
