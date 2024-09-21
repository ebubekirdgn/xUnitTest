using LibraryManagement.Core.Models;

namespace LibraryManagement.Core.Repositories
{
    public interface IBookRepository
    {
        Task AddAsync(Book book);
        Task RemoveAsync(int id);
        Task<IEnumerable<Book>> GetAllAsync();
    }
}
