﻿using Microsoft.EntityFrameworkCore;
using Practica_Final.DAL;
using Practica_Final.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Practica_Final.BLL
{
   public class PrestamosBLL
    {
        public static bool Guardar(Prestamo prestamo)
        {
            if (!Existe(prestamo.PrestamoId))
                return Insertar(prestamo);
            else
                return Modificar(prestamo);
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool ok = false;

            try
            {
                ok = contexto.Prestamos.Any(p => p.PrestamoId == id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return ok;
        }

        private static bool Insertar(Prestamo prestamo)
        {
            Contexto contexto = new Contexto();
            bool ok = false;

            try
            {
                foreach (var item in prestamo.PrestamosDetalles)
                {
                    item.Juego.Existencia -= item.Cantidad;
                    contexto.Entry(item.Juego).State = EntityState.Modified;
                }
                contexto.Prestamos.Add(prestamo);
                ok = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return ok;
        }

        private static bool Modificar(Prestamo prestamo)
        {
            Contexto contexto = new Contexto();
            bool ok = false;
            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM PrestamoDetalle Where PrestamoId={prestamo.PrestamoId}");
                foreach (var item in prestamo.PrestamosDetalles)
                {
                    contexto.Entry(item).State = EntityState.Added;
                }
                contexto.Entry(prestamo).State = EntityState.Modified;
                ok = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return ok;
        }

        public static Prestamo Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Prestamo prestamo;

            try
            {
                prestamo = contexto.Prestamos.Where(p => p.PrestamoId == id).Include(p => p.PrestamosDetalles)
                    .ThenInclude(d => d.Juego).SingleOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return prestamo;
        }

        public static bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool ok = false;

            try
            {
                var eliminar = contexto.Prestamos.Find(id);
                if(eliminar != null)
                {
                    contexto.Entry(eliminar).State = EntityState.Deleted;
                    ok = contexto.SaveChanges() > 0;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return ok;
        }

        public static List<Prestamo> GetPrestamos(Expression<Func<Prestamo, bool>> criterio)
        {
            Contexto contexto = new Contexto();
            List<Prestamo> lista = new List<Prestamo>();

            try
            {
                lista = contexto.Prestamos.Where(criterio).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}