using System;
using System.Collections.Generic;

namespace Administracion_hotel.Models;

public partial class Estadohabitacion
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Habitacione> Habitaciones { get; set; } = new List<Habitacione>();
}
