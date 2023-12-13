namespace relationshipsapi.Data.entities;

public class Book
{
    public int bookid { get; set; }
    public string title { get; set; }
    public virtual ICollection<Author> Authors { get; set; }
}