using System;
using System.Collections.Generic;

namespace Administracion_hotel.Models;

public partial class Reserva
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdHabitacion { get; set; }

    public DateOnly FechaInicio { get; set; }

    public DateOnly FechaFinalizacion { get; set; }

    public int? IdEstadoReserva { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual EstadoReserva? IdEstadoReservaNavigation { get; set; }

    public virtual Habitacione? IdHabitacionNavigation { get; set; }
}
