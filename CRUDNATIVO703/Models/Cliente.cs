using System.ComponentModel.DataAnnotations;

namespace CRUDNATIVO703.Models
{
    public class Cliente
    {
        [Key] // Llave primaria
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "La dirección debe tener entre 3 y 150 caracteres")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Phone(ErrorMessage = "Formato de teléfono inválido")]
        [StringLength(20, ErrorMessage = "El teléfono no puede superar los 20 caracteres")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "mosquera")]
        [StringLength(10, ErrorMessage = "El documento no puede superar los 20 caracteres")]
        public string Documento { get; set; }
    }
}
