namespace OkOk.Models
{
    public class SummarisedReport
    {
        public Guid? MessageId{get; set;}
        public string SenderId{get; set;}
        public int Amount{get; set;}
        public string Content{get; set;}
    }
}