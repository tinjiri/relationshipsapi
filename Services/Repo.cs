using relationshipsapi.Data.entities;
using relationshipsapi.Data;
using relationshipsapi.Abstract;
namespace relationshipsapi.Services;

public class Repo : IRepo
{
    private readonly DataContext context;
    public Repo(DataContext _context)
    {
        context=_context;
    }

    public IQueryable<Author> getAuthors(){
       return context.Vanyori;
    }
}