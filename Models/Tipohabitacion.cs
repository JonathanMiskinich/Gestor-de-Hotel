﻿using System;
using System.Collections.Generic;

namespace Administracion_hotel.Models;

public partial class Tipohabitacion
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Habitacione> Habitaciones { get; set; } = new List<Habitacione>();
}