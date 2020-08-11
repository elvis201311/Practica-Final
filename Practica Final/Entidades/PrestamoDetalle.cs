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
        public int PrestamosId { get; set; }
        public int JuegoId { get; set; }
        public double Cantidad { get; set; }

        public PrestamoDetalle(int Prestamoid, int Juegoid, int cantidad)
        {
            Id = 0;
            PrestamosId = Prestamoid;
            JuegoId = Juegoid;
            Cantidad = cantidad;
        }
    }
}