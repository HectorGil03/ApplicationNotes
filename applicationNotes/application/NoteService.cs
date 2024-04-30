public class NoteService
{
    private readonly INoteRepository _noteRepository;

    public NoteService(INoteRepository noteRepository)
    {
        _noteRepository = noteRepository;
    }

    // Implementación de métodos para crear, leer, actualizar y eliminar notas
}