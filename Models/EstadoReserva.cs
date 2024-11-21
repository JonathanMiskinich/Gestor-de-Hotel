using System;
using System.Collections.Generic;

namespace Administracion_hotel.Models;

public partial class EstadoReserva
{
    public int Id { get; private set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Reserva> Reservas { get; private set; } = new List<Reserva>();
}
