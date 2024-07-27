using DnsClient;

namespace MongoDbTestes.Models
{
    public class CreateReviewBookModel
    {
        public int Rating { get; set; }
        public string Comment { get; set; } 
        public string UserName { get; set; }
    }
}
