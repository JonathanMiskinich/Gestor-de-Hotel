using System;
using System.Collections.Generic;

namespace Administracion_hotel.Models;

public partial class Tipohabitacion
{
    public int Id { get; private set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Habitacione> Habitaciones { get; private set; } = new List<Habitacione>();
    public Tipohabitacion() {}
    public Tipohabitacion(string Descripcion)
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
            this.Habitaciones.Remove(habitacion);
    }
}
