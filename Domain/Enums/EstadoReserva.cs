using System;
using System.Collections.Generic;

namespace Administracion_hotel.Models;

public partial class EstadoReserva
{
    public int Id { get; private set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Reserva> Reservas { get; private set; } = new List<Reserva>();

    public EstadoReserva() {}
    public EstadoReserva(string Descripcion)
    {
        this.Descripcion = Descripcion;
    }

    public void AgregarReserva(Reserva reserva)
    {
        this.Reservas.Add(reserva);
    }

    public void EliminarReserva(Reserva reserva)
    {
        if(this.Reservas.Contains(reserva))
            Reservas.Remove(reserva);
    }
}
