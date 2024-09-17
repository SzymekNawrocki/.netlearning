namespace MyBoards.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int Author {  get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
