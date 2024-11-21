using System;
using System.Collections.Generic;

namespace Administracion_hotel.Models;

public partial class Factura
{
    public int Id { get; private set; }

    public int? IdCliente { get; private set; }

    public int? IdReserva { get;  private set; }

    private decimal MontoTotal;

    public DateOnly FechaEmision { get; private set; }

    public virtual Cliente? IdClienteNavigation { get; private set; }

    public virtual Reserva? IdReservaNavigation { get; private set; }

    public decimal MONTO_TOTAL
    {
        get => this.MontoTotal;
        set 
        {
            if(value < 0)
                throw new Exception("Monto ingresado invalido.");
            this.MontoTotal = value;
        }
    }

}
