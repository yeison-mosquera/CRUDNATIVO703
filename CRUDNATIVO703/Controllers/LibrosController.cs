using CRUDNATIVO703.Data;
using CRUDNATIVO703.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDNATIVO703.Controllers
{
    public class LibrosController : Controller


    {
        //Llamar AplicationmDbContext

        private readonly Data.AplicationDbContext _context;


        //Constructor

        public LibrosController(AplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Libro> ListLibros = _context.Libros;
            return View(ListLibros);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Libro libro)// Resivimos el parametro de libro
        {
            if (ModelState.IsValid) // Validamos el modelo
            {
                _context.Libros.Add(libro); //Guardamos los datos 
                _context.SaveChanges(); //Confirmamos los cambios

                TempData["mensaje"] = "El libro se ha creado correctamente"; //Mensaje de confirmacion

                return RedirectToAction("Index"); //Redirigimos a la vista principal
            }
            return View(); //Retornamos la vista 
        }

        public IActionResult Edit(int? id) //Recibimos el parametro del id
        {
         if (id== null || id == 0)
            {
                return NotFound(); //Si el id es nulo o 0 retornamos NotFound
            }

         //Consular el libro 


         var Libro = _context.Libros.Find(id); //Buscamos el libro por el id

        if (Libro == null)
                {
                    return NotFound(); //Si no se encuentra el libro retornamos NotFound
            }

           return View(Libro); //Retornamos la vista con el libro encontrado
        }
        [HttpPost]
        public IActionResult Edit(Libro libro) //Recibimos el parametro del libro
        {
            if (ModelState.IsValid) //Validamos el modelo
            {
                _context.Libros.Update(libro); //Actualizamos el libro
                _context.SaveChanges(); //Confirmamos los cambios
                TempData["mensaje"] = "El libro se ha editado correctamente"; //Mensaje de confirmacion
                return RedirectToAction("Index"); //Redirigimos a la vista principal
            }
            return View(); //Retornamos la vista con el libro editado
        }
    }
}
