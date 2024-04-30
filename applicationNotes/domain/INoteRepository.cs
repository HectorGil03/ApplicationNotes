public interface INoteRepository
{
    Task<Note> GetByIdAsync(int id);
    Task<IEnumerable<Note>> GetAllAsync();
    Task AddAsync(Note note);
    Task UpdateAsync(Note note);
    Task DeleteAsync(Note note);
}