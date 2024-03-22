namespace Mission_11.Models
{
    public interface IBookstoreRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
