#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
namespace DojoSurveyWithValidation.Models;  

public class DatosFormulario{
    [Required(ErrorMessage = "Este campo es obligatorio!!!")]
    [MinLength(2, ErrorMessage = "El nombre debe tener al menos 2 caracteres")]

    public string? Nombre { get; set; }
    [Required(ErrorMessage = "Este campo es obligatorio!!!")]

    public string? Locacion { get; set; }
    [MaybeNull]
    
    public string? LenguajeFavorito { get; set; }
    [MinLength(20, ErrorMessage = "El Comentario debe contener al menos 20 caracteres")]
    public string? Comentario { get; set; }
}