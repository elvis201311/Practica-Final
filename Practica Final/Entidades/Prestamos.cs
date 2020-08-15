﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Practica_Final.Entidades
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int AmigoId { get; set; }
        public string Observacion { get; set; }
        public int CantidadJuegos { get; set; }

        [ForeignKey("AmigoId")]
        public virtual Amigos Amigo { get; set; }

        [ForeignKey("PrestamoId")]
        public virtual List<PrestamoDetalle> PrestamosDetalles { get; set; } = new List<PrestamoDetalle>();

    }
}