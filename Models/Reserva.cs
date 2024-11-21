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

    public virtual Cliente? ClienteNavigation { get; private set; }

    public virtual EstadoReserva? EstadoReservaNavigation { get; private set; }

    public virtual Habitacione? HabitacionNavigation { get; private set; }

    public Reserva() {}
    public Reserva(int IdCliente, int IdHabitacion, DateOnly Inicio, DateOnly Final, int IdEstadoReserva, Cliente cliente, Habitacione habitacion, EstadoReserva estado)
    {
        this.IdCliente = IdCliente;
        this.IdHabitacion = IdHabitacion;
        FechaInicio = Inicio;
        FechaFinalizacion = Final;
        this.IdEstadoReserva = IdEstadoReserva;
        this.ClienteNavigation = cliente;
        this.EstadoReservaNavigation = estado;
        HabitacionNavigation = habitacion;
    }
}
