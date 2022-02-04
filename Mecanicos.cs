using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parque_de_diversiones
{
    class Mecanicos : Atracciones
    {
       // Mecanicos[] juegos = new Mecanicos[4];

        public Mecanicos(string _codigo, int _edad, double _estatura, double _costo,string _nombre) : base( _codigo, _edad,  _estatura,  _costo, _nombre)
        {

        }
        public override string Jugar(Manilla jugador)
        {
            double descuento = 100 - 0.08;
            try
            {
                if (jugador.edad >= edad && jugador.estatura >= estatura )
                {
                    if(jugador.saldo >= costo)
                    {

                        for (int i = 0; i < jugador.juegos.Count; i++)
                        {
                            if (jugador.juegos[i] == nombre)
                            {
                                costo = costo * descuento;
                            }

                            jugador.saldo -= costo;
                            break;
                        }
                        jugador.juegos.Add(nombre);
                        Console.WriteLine(jugador.Consulta_Juegos());
                        Console.WriteLine(jugador.Consulta_Saldo());
                    }

                }
                return ("Jugando Mecanico" + nombre);
            }
            catch (Exception ex)
            {
                return "no cumple con los requisitos" + ex;
            }

        }
       
    }
}
