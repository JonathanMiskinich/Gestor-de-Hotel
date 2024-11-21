using System;
using System.Collections.Generic;

namespace Administracion_hotel.Models;

public partial class Habitacione
{
    public int Id { get; private set;}

    public int? Numero { get; set; }

    public int? Tipo { get; set; }

    public decimal PrecioPorNoche;

    public int? Estado { get; set; }

    public virtual Estadohabitacion? EstadoNavigation { get; private set; }

    public virtual ICollection<Reserva> Reservas { get; private set; } = new List<Reserva>();

    public virtual Tipohabitacion? TipoNavigation { get; private set; }

    public decimal PRECIO_POR_NOCHE
{
    get => PrecioPorNoche;
    set
    {
        if (value < 0)
            throw new ArgumentException("El precio por noche no puede ser negativo.");
        PrecioPorNoche = value;
    }
}
}
