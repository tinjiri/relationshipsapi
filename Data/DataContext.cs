using Microsoft.EntityFrameworkCore;
using relationshipsapi.Data.entities;

namespace relationshipsapi.Data;
public class DataContext : DbContext
{
    public  DataContext(DbContextOptions<DataContext> options): base (options){} 

    public DbSet<Author> Vanyori {get; set; } 
    public DbSet<Book> Mabhuku {get; set; } 
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
          // Configure the one-to-many relationship between Author and AuthorBook
        modelBuilder.Entity<Author>() 
            .ToTable("author") 
            .HasOne(a=>a.Book) 
            .WithMany(b=>b.Authors)   
            .HasForeignKey(a=>a.bookid);

        base.OnModelCreating(modelBuilder);
    }
}
