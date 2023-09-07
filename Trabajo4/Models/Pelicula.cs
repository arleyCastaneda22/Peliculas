using System;
using System.Collections.Generic;

namespace Trabajo4.Models;

public partial class Pelicula
{
    public int Id { get; set; }

    public string? Titulo { get; set; }

    public string? Director { get; set; }

    public string? Genero { get; set; }

    public string? Sipnosis { get; set; }

    public string? Url { get; set; }

    public int? Cantidad { get; set; }
}
