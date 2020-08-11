using System;
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

        //———————————————————————————[ ForeingKeys ]———————————————————————————
        [ForeignKey("PrestamoId")]
        public virtual List<PrestamoDetalle> Detalle { get; set; } = new List<PrestamoDetalle>();

        [ForeignKey("AmigoId")]
        public Amigos Amigos { get; set; }

    }
}