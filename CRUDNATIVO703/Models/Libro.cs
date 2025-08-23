using System.ComponentModel.DataAnnotations;

namespace CRUDNATIVO703.Models
{

    public class Libro
    {
        [Key] // Llave primaria
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(50, ErrorMessage = "El campo debe ser mínimo 3 caracteres y máximo 50 caracteres", MinimumLength = 3)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(50, ErrorMessage = "El campo debe ser mínimo 3 caracteres y máximo 50 caracteres", MinimumLength = 3)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaLanzamiento { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(50, ErrorMessage = "El campo debe ser mínimo 3 caracteres y máximo 50 caracteres", MinimumLength = 3)]
        public string Autor { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(50, ErrorMessage = "El campo debe ser mínimo 3 caracteres y máximo 50 caracteres", MinimumLength = 3)]
        public string Precio { get; set; }
    }
}
