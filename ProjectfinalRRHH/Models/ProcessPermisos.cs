﻿using System;
using System.Collections.Generic;

namespace ProjectfinalRRHH.Models
{
    public partial class ProcessPermisos
    {
        public string Empleado { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public string Comentario { get; set; }
        public int Id { get; set; }
    }
}
