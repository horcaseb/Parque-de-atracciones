using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parque_de_diversiones
{
    class Atracciones
    {
        public int edad;
        public string nombre;
        public double estatura;
        public double costo;
        public string codigo;

        
        public Atracciones( string _codigo,int _edad, double _estatura ,double _costo, string _nombre)
        {
            codigo = _codigo;
            nombre = _nombre;
            edad = _edad;
            estatura = _estatura;
            costo = _costo;
        }

        public virtual string Jugar(Manilla _jugador)
        {
            return "cobro predeterminado";
        }
    }
}
