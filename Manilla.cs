using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parque_de_diversiones
{
    class Manilla
    {
        public int edad;
        public int jugadasV;
        public double saldo;
        public double estatura;
        public List<string> juegos = new List<string>();

        public Manilla(int _edad, double _estatura, double _saldo)
        {
            edad = _edad;
            estatura = _estatura;
            saldo = _saldo;

        }

       

        public void Recargar(double _recarga)
        {
            saldo += _recarga;
        }

        public double Consulta_Saldo()
        {
            return (saldo);
        }
        public List<string> Consulta_Juegos()
        {
            return (juegos);
        }
       
       
    }

}
