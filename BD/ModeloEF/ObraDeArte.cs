﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BD.ModeloEF
{
    public partial class ObraDeArte
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? AnioCreacion { get; set; }
    }
}
