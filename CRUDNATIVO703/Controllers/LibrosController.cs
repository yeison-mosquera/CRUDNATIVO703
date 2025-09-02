using CRUDNATIVO703.Data;
using CRUDNATIVO703.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDNATIVO703.Controllers
{
    public class LibrosController : Controller
    {
        private readonly AplicationDbContext _context;

        // Constructor
        public LibrosController(AplicationDbContext context)
        {
            _context = context;
        }

        // INDEX
        public IActionResult Index()
        {
            IEnumerable<Libro> ListLibros = _context.Libros;
            return View(ListLibros);
        }

        // CREATE GET
        public IActionResult Create()
        {
            return View();
        }

        // CREATE POST
        [HttpPost]
        public IActionResult Create(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libros.Add(libro);
                _context.SaveChanges();

                TempData["mensaje"] = "El libro se ha creado correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        // EDIT GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            var libro = _context.Libros.Find(id);
            if (libro == null)
                return NotFound();

            return View(libro);
        }

        // EDIT POST
        [HttpPost]
        public IActionResult Edit(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libros.Update(libro);
                _context.SaveChanges();

                TempData["mensaje"] = "El libro se ha editado correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        // DELETE GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            var libro = _context.Libros.Find(id);
            if (libro == null)
                return NotFound();

            return View(libro);
        }

        // DELETE POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var libro = _context.Libros.Find(id);
            if (libro == null)
                return NotFound();

            _context.Libros.Remove(libro);
            _context.SaveChanges();

            TempData["mensaje"] = "El libro se ha eliminado correctamente";
            return RedirectToAction("Index");
        }
    }
}