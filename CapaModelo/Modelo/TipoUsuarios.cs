﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.Modelo
{
    public class TipoUsuarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
