﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlataformaDigital.Models
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; } // "Profesor" o "Alumno"
    }
}