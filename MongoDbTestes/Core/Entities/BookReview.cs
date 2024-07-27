namespace MongoDbTestes.Core.Entities
{
    public class BookReview(int rating, string comment, string userName)
    {
        public int Rating { get; private set; } = rating;
        public string Comment { get; private set; } = comment;
        public string UserName { get; private set; } = userName;
    }
}
