using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Practica_Final.Entidades
{
   public class PrestamoDetalle
    {

        [Key]
        public int Id { get; set; }
        public int PrestamoId { get; set; }
        public int Cantidad { get; set; }
        public int JuegoId { get; set; }

        [ForeignKey("JuegoId")]
        public virtual Juegos Juego { get; set; }
    }
}