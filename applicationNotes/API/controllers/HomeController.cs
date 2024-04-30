public class HomeController : Controller
{
        // Acción Index para mostrar la página inicial
    public IActionResult Index()
    {
        // Aquí puedo cargar todas las notas existentes y pasarlas a la vista
        List<Note> notes = new List<Note>(); // Por ahora, una lista vacía
        return View(notes);
    }

    // aqui agrego una nueva nota
    [HttpPost]
    public IActionResult AddNote(string content)
    {
        // Aquí creo una nueva nota con el contenido recibido y la guardo en la base de datos
        return RedirectToAction("Index");
    }

    // aqui busco notas existentes
    [HttpPost]
    public IActionResult SearchNote(string search)
    {
        // Aquí busco notas que coincidan con el término de búsqueda y las paso a la vista
        List<Note> notes = new List<Note>(); // Por ahora, una lista vacía
        return View("Index", notes);
    }

    // elimino una nota existente
    [HttpPost]
    public IActionResult DeleteNote(int id)
    {
        // Aquí puedo eliminar la nota con el ID especificado de la base de datos
        return RedirectToAction("Index");
    }
}
