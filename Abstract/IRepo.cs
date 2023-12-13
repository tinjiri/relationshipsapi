using relationshipsapi.Data.entities; 

namespace relationshipsapi.Abstract;
public interface IRepo
{
    IQueryable<Author> getAuthors(); 
}
