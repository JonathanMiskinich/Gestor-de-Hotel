using System;
using System.Collections.Generic;
using Org.BouncyCastle.Bcpg;

namespace Administracion_hotel.Models;

public partial class Cliente
{
    public int Id { get; private set;}

    private string Nombre = null!;

    private string Apellido = null!;

    public string Telefono { get; set; } = null!;

    private string? Email;

    public int Dni;

    public virtual ICollection<Factura> Facturas { get; private set; } = new List<Factura>();

    public virtual ICollection<Reserva> Reservas { get; private set; } = new List<Reserva>();

    public Cliente() {}
    public Cliente(string nombre, string apellido, string telefono, string email, int dni)
    {
        this.NOMBRE = nombre;
        this.APELLIDO = apellido;
        this.Telefono = telefono;
        this.EMAIL = email;
        this.DNI = dni;
    }

    public int DNI
    {
        get => this.Dni;
        set
        {
            if(value < 0)
                throw new Exception("Valor de Dni invalido.");
            Dni = value;
        }
    }
    public string NOMBRE
    {
        get => this.Nombre;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception("El nombre no puede estar vacío o con espacion.");
            Nombre = value;
        }
    }


    public string APELLIDO
    {
        get => this.Apellido;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception("El apellido no puede estar vacío o con espacion.");
            Apellido = value;
        }
    }

    public string? EMAIL
    {
        get => this.Email;
        set
        {
            if(value != null)
            {
                if(!value.Contains('@'))
                    throw new Exception("Email invalido");
            }
            this.Email = value;
        }
    }
}
