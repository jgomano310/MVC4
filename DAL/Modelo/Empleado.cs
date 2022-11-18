using System;
using System.Collections.Generic;

namespace DAL.Modelo;

public partial class Empleado
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int? IdAreas { get; set; }

    public virtual Area? IdAreasNavigation { get; set; }
}
