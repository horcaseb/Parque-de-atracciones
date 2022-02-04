using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parque_de_diversiones
{
    class Virtuales :Atracciones
    {
   
        
        public Virtuales(string _codigo, int _edad, double _estatura, double _costo, string _nombre) : base( _codigo, _edad, _estatura, _costo, _nombre)
        {

        }
        public override string Jugar(Manilla jugador)
        {
            double sobrecargo = 0.05;

            try
            {
                if (jugador.edad >= edad && jugador.estatura >= estatura)
                {
                    if (jugador.saldo >= costo)
                    {
                        if (jugador.jugadasV > 2)
                        {
                            costo += (costo * sobrecargo);
                        }
                        jugador.saldo -= costo;
                        jugador.juegos.Add(nombre);
                        jugador.jugadasV++;
                        Console.WriteLine( jugador.Consulta_Juegos());
                        Console.WriteLine( jugador.Consulta_Saldo());
                    }

                }
                return "Jugando virtual" + nombre;
            }
            catch (Exception e)
            {
                return "no cumples con una de las condiciones" + e;
                
            }
            
        }
       
    }
}
