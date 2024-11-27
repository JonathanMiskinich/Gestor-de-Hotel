using System;
using System.Collections.Generic;

namespace Administracion_hotel.Models;

public partial class Estadohabitacion
{
    public int Id { get; private set; }

    public string Descripcion { get; private set; } = null!;

    public virtual ICollection<Habitacione> Habitaciones { get;  private set; } = new List<Habitacione>();

    public Estadohabitacion() {}
    public Estadohabitacion(string Descripcion)
    {
        this.Descripcion = Descripcion;
    }

    public void AgregarHabitacion(Habitacione habitacion)
    {
        this.Habitaciones.Add(habitacion);
    }

    public void EliminarHabitacion(Habitacione habitacion)
    {
        if(this.Habitaciones.Contains(habitacion))
            Habitaciones.Remove(habitacion);
    }
}
