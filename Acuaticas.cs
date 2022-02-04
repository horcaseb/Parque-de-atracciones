using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parque_de_diversiones
{
    class Acuaticas :Atracciones
    {

        public Acuaticas( string _codigo, int _edad, double _estatura, double _costo, string _nombre) :base ( _codigo, _edad, _estatura, _costo, _nombre)
        {

        }
        public override string Jugar(Manilla jugador)
        {
            double descuento = 100 - 0.07;
            if (jugador.edad >= edad && jugador.estatura >= estatura)
            {
                try
                {
                    if (jugador.saldo >= costo)
                    {
                        if (jugador.edad > 45 && jugador.edad < 50)
                        {
                            costo = costo * descuento;
                        }
                        jugador.saldo -= costo;
                        jugador.juegos.Add(nombre);
                        Console.WriteLine(jugador.Consulta_Juegos());
                        Console.WriteLine(jugador.Consulta_Saldo());
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    return "No cumples con los requisitos" + nombre;

                }

            }
            return "Jugando acuatica " + nombre;
        }
       
    }
}
