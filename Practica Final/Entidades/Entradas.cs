﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Practica_Final.Entidades
{
    public class Entradas
    {
        [Key]
        public int EntrdaId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int JuegoId { get; set; }
        public int Cantidad { get; set; }
    }
}