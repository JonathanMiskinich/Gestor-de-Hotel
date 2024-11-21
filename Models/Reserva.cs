using System;
using System.Collections.Generic;

namespace Administracion_hotel.Models;

public partial class Reserva
{
    public int Id { get; private set; }

    public int? IdCliente { get; private set; }

    public int? IdHabitacion { get; private set; }

    public DateOnly FechaInicio { get; private set; }

    public DateOnly FechaFinalizacion { get; set; }

    public int? IdEstadoReserva { get; set; }

    public virtual ICollection<Factura> Facturas { get; private set; } = new List<Factura>();

    public virtual Cliente? IdClienteNavigation { get; private set; }

    public virtual EstadoReserva? IdEstadoReservaNavigation { get; private set; }

    public virtual Habitacione? IdHabitacionNavigation { get; private set; }
}
