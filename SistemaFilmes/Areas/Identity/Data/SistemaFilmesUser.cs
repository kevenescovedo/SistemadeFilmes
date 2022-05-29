using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SistemaFilmes.Areas.Identity.Data;

// Add profile data for application users by adding properties to the SistemaFilmesUser class
public class SistemaFilmesUser : IdentityUser
{
    public string NameComplete { get; set; } = string.Empty;
    [Required(ErrorMessage = "Este campo deve ser obrigatório")]
    [StringLength(12, MinimumLength = 3)]
    [DataType(DataType.Date)]
    public DateTime Birthday { get; set; }
}

