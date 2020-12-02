using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DataVentasWeb.DAL;
using DataVentasWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace DataVentasWeb.BLL
{
    public class JugadoresBLL
    {
        private readonly Contexto _contexto;

        public JugadoresBLL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> Guardar(Jugadores jugador)
        {
            if (!await Existe(jugador.JugadorId))
                return await Insertar(jugador);
            else
                return await Modificar(jugador);
        }

        public async Task<bool> Insertar(Jugadores jugador)
        {
            bool paso = false;

            try
            {
                _contexto.Jugadores.Add(jugador);
                paso = await _contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public async Task<bool> Modificar(Jugadores jugador)
        {
            bool paso = false;


            try
            {
                _contexto.Entry(jugador).State = EntityState.Modified;

                paso = await _contexto.SaveChangesAsync() > 0;

            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }

        public async Task<bool> Existe(int id)
        {
            bool encontrado = false;

            try
            {
                encontrado = await _contexto.Jugadores.AnyAsync(v => v.JugadorId == id);
            }
            catch (Exception)
            {
                throw;
            }

            return encontrado;
        }

        public List<Jugadores> GetJugadores(Expression<Func<Jugadores, bool>> jugadores)
        {
            List<Jugadores> Lista = new List<Jugadores>();

            try
            {
                Lista = _contexto.Jugadores.Where(jugadores).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }
    }
}
