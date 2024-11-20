using System;
using System.Collections.Generic;

namespace Administracion_hotel.Models;

public partial class Factura
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdReserva { get; set; }

    public decimal? MontoTotal { get; set; }

    public DateOnly FechaEmision { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Reserva? IdReservaNavigation { get; set; }
}
