namespace relationshipsapi.Data.entities;

public class Author
{
    public int authorid { get; set; }
    public string name { get; set; }
       // Foreign key for the Book entity
    public int? bookid { get; set; }

    // Navigation property for the book an author belongs to
    public virtual Book Book { get; set; }
}