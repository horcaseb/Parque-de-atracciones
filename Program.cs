using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parque_de_diversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            //mecacnicas
            Mecanicos[] mecanicasjuegos = new Mecanicos[4];

            Mecanicos Hollywood_Rip_Ride_Rockit = new Mecanicos("MC001", 16, 1.4, 25000, "Hollywood Rip Ride Rockit");
            Mecanicos Flight_of_the_Hippogrifo = new Mecanicos("MC002", 12, 1, 15000, "Flight of the Hippogrifo ");
            Mecanicos The_Incredible_Hulk_Coaster = new Mecanicos("MC003", 16, 1.4, 20000, "The Incredible Hulk Coaster ");
            Mecanicos The_Cat_in_the_Hat = new Mecanicos("MC004", 8, 0.7, 12000, "The Cat in the Hat ");

            mecanicasjuegos[0] = Hollywood_Rip_Ride_Rockit;
            mecanicasjuegos[1] = Flight_of_the_Hippogrifo;
            mecanicasjuegos[2] = The_Incredible_Hulk_Coaster;
            mecanicasjuegos[3] = The_Cat_in_the_Hat;

            //acuaticas
            Acuaticas[] acuaticasjuegos = new Acuaticas[4];

            Acuaticas Popeye_and_brutoss_bilge_rat_bargues = new Acuaticas("AC001", 14, 1.2, 15000, "Popeye and brutoss bilge rat bargues ");
            Acuaticas Dudley_do_rait_ripsaw_falls = new Acuaticas("AC002", 12, 1.1, 16000, "Dudley do rait ripsaw falls ");
            Acuaticas One_fish_two_fish_red_fish_blue_fish = new Acuaticas("AC003", 6, 0.5, 12000, "One fish two fish red fish blue fish ");
            Acuaticas Karakatau_aqua_coaster = new Acuaticas("AC004", 12, 1.2, 18000, "Karakatau aqua coaster ");

            acuaticasjuegos[0] = Popeye_and_brutoss_bilge_rat_bargues;
            acuaticasjuegos[1] = Dudley_do_rait_ripsaw_falls;
            acuaticasjuegos[2] = One_fish_two_fish_red_fish_blue_fish;
            acuaticasjuegos[3] = Karakatau_aqua_coaster;

            //virtuales
            Virtuales[] virtualesjuegos = new Virtuales[4];

            Virtuales Simpsons_ride = new Virtuales("VI001", 8, 1, 12000, "Simpsons ride ");
            Virtuales Revange_of_the_mummy = new Virtuales("VI002", 12, 1.3, 15000, "Revange of the mummy ");
            Virtuales Harry_potter_and_the_scape_of_the_gringotts = new Virtuales("VI003", 12, 1.3, 18000, "Harry potter and the scape of the gringotts ");
            Virtuales Transformers_ride_3D = new Virtuales("VI004", 12, 1.2, 18000, "Transformers ride 3D ");

            virtualesjuegos[0] = Simpsons_ride;
            virtualesjuegos[1] = Revange_of_the_mummy;
            virtualesjuegos[2] = Harry_potter_and_the_scape_of_the_gringotts;
            virtualesjuegos[3] = Transformers_ride_3D;

            Console.WriteLine("ingrese su edad");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su estatura en m; use ,");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("¿cuanto desea recargar?");
            double c = double.Parse(Console.ReadLine());

            Manilla Alex = new Manilla(a,b,c);          //comprar manillas

            bool r = true;
            while (r)
            {

                Console.WriteLine("¿desea recargar la manilla? s ó n");         //recargar manilla
                string rescargar = Console.ReadLine();
                while (rescargar != "s" && rescargar != "n")
                {
                    Console.WriteLine("respuesta erronea, ingrese nuevamente la respuesta");
                    Console.WriteLine("¿desea recargar la manilla? s ó n");
                    rescargar = Console.ReadLine();
                }

                if (rescargar == "s")
                {
                    Console.WriteLine("¿cuanto desea recargar a la manilla?");
                    double recarga = double.Parse(Console.ReadLine());
                    Alex.Recargar(recarga);
                    Console.WriteLine("su saldo actual es de " + Alex.saldo);

                }

                Console.WriteLine("¿en qué juego deséa jugar?");            //Juego que jugar
                Console.WriteLine("1=Acuaticos, 2=Mecanicos, 3=Virtuales");
                int respuesta = int.Parse(Console.ReadLine());

                while (respuesta != 1 && respuesta != 2 && respuesta !=3)       //validacion
                {
                    Console.WriteLine("respuesta erronea, ingrese nuevamente la atracción");
                    Console.WriteLine("1=Acuaticos, 2=Mecanicos, 3=Virtuales");
                    respuesta = int.Parse(Console.ReadLine());
                }
                if (respuesta == 1)                         //acuaticos
                {
                    Console.WriteLine("ingresa el numero del juego que quieres jugar");
                    
                   for(int i = 0; i < acuaticasjuegos.Length; i++)
                    {
                        Console.WriteLine(i + "=" + acuaticasjuegos[i].nombre);
                    }
                    int juego = int.Parse(Console.ReadLine());

                    while(juego !=0 && juego != 1 && juego != 2 && juego != 3)
                    {
                        Console.WriteLine("respuesta erronea, ingrese nuevamente la atracción");
                        Console.WriteLine("ingresa el numero del juego que quieres jugar");
                        juego = int.Parse(Console.ReadLine());
                    }
                   Console.WriteLine( acuaticasjuegos[juego].Jugar(Alex));
                    
                }
                if (respuesta == 2)            //mecanicos
                {
                    Console.WriteLine("ingresa el numero del juego que quieres jugar");

                    for (int i = 0; i < mecanicasjuegos.Length; i++)
                    {
                        Console.WriteLine(i + "=" + mecanicasjuegos[i].nombre);
                    }
                    int juego = int.Parse(Console.ReadLine());

                    while (juego != 0 && juego != 1 && juego != 2 && juego != 3)
                    {
                        Console.WriteLine("respuesta erronea, ingrese nuevamente la atracción");
                        Console.WriteLine("ingresa el numero del juego que quieres jugar");
                        juego = int.Parse(Console.ReadLine());

                    }
                    Console.WriteLine(mecanicasjuegos[juego].Jugar(Alex));

                }
                if (respuesta == 3)        //virtuales
                {
                    Console.WriteLine("ingresa el numero del juego que quieres jugar");

                    for (int i = 0; i < virtualesjuegos.Length; i++)
                    {
                        Console.WriteLine(i + "=" + virtualesjuegos[i].nombre);
                    }
                    int juego = int.Parse(Console.ReadLine());

                    while (juego != 0 && juego != 1 && juego != 2 && juego != 3)
                    {
                        Console.WriteLine("respuesta erronea, ingrese nuevamente la atracción");
                        Console.WriteLine("ingresa el numero del juego que quieres jugar");
                        juego = int.Parse(Console.ReadLine());

                    }
                    Console.WriteLine(virtualesjuegos[juego].Jugar(Alex));

                }
            }
        }
    }
}
