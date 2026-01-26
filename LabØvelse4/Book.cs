namespace LabØvelse4
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublishedYear { get; set; }

        public Book(string Title)
        {
            this.Title = Title;
        }
    }
}
