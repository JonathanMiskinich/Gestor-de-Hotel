using System;
using System.Collections.Generic;

namespace Administracion_hotel.Models;

public partial class Estadohabitacion
{
    public int Id { get; private set; }

    public string Descripcion { get; private set; } = null!;

    public virtual ICollection<Habitacione> Habitaciones { get;  private set; } = new List<Habitacione>();
}
