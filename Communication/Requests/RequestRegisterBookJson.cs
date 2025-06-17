namespace LibraryManagement.Communication.Requests;

public class RequestRegisterBookJson
{
    public required string Title { get; set; }

    public required string Author { get; set; }

    public BookGenre Genre { get; set; }

    public float Price { get; set; }

    public int StockQuantity { get; set; }
}
