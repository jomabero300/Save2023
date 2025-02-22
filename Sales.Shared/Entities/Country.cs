using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sales.Shared.Entities;

public class Country
{
    public int Id { get; set; }

    [Column(TypeName = "varchar(100)")]
    [MaxLength(100, ErrorMessage = "El máximo tamaño del campo {0} es {1} caractéres")]
    [Required(ErrorMessage = "El campo {0} es requerido")]
    [Display(Name = "País")]
    public string Name { get; set; } = null!;
}