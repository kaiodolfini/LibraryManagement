namespace LibraryManagement
{
    public enum BookGenre
    {
        Fiction,
        Action,
        Mystery,
        Romance,
        Fantasy
    }

    public class Book
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Title { get; set; }

        public string Author { get; set; }

        public BookGenre Genre { get; set; }

        public float Price { get; set; }

        public int StockQuantity { get; set; } 
    }
}