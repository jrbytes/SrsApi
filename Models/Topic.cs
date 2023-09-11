namespace SrsApi.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required DateTime DateOfAddition { get; set; }
        public required DateTime LastReviewDate { get; set; }
    }
}