using System;
using System.Collections.Generic;

namespace Administracion_hotel.Models;

public partial class Habitacione
{
    public int Id { get; set; }

    public int? Numero { get; set; }

    public int? Tipo { get; set; }

    public decimal PrecioPorNoche { get; set; }

    public int? Estado { get; set; }

    public virtual Estadohabitacion? EstadoNavigation { get; set; }

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();

    public virtual Tipohabitacion? TipoNavigation { get; set; }
}
