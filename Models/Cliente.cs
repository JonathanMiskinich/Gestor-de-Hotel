using System;
using System.Collections.Generic;

namespace Administracion_hotel.Models;

public partial class Cliente
{
    private int Id { get;}

    private string Nombre = null!;

    private string Apellido = null!;

    public string Telefono { get; set; } = null!;

    public string? Email { get; set; }

    public int Dni { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
