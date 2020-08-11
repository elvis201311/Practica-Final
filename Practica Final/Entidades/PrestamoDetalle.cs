using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Practica_Final.Entidades
{
   public class PrestamoDetalle
    {
       
        [Key]
        public int Id { get; set; }
        public int PrestamoId { get; set; }
        public int JuegoId { get; set; }
        public int Cantidad { get; set; }

        public PrestamoDetalle(int PrestamoId, int JuegoId, int cantidad)
        {
            Id = 0;
            PrestamoId = PrestamoId;
            JuegoId = JuegoId;
            Cantidad = cantidad;
        }
    }
}