using System.Globalization;

namespace TransferServiceWebAPI.Models
{
    public class CreateTransferDto
    {
        public string SourceAcountNumber { get; set; }
        public string DestinationAcountNumber { get; set;}
        public decimal Amount { get; set; }
    }
}
