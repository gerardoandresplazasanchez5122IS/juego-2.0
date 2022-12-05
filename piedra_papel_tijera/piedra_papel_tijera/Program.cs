using System;

namespace piedra_papel_tijera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] es = {"piedra","palpel","tijera"};
            int juegos, Wb=0, Wj=0,Jugador=0,bot=0 ;
            Console.WriteLine("bienvenido al juego piera papel o tijera ");
            Console.WriteLine("cuantas veces tiene que ganar un jugador: ");
            juegos = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("--------------que empieze el juego----------------");
            for (int i =0; i<3;i++)
            {
                Console.Write("\npara escojer {0} escoja -> {1}",es[i],i+1);
            }
          


            while (Wb <juegos && Wj<juegos) {
               

                Console.Write("\n ingrese su eleccion\n->");
                Jugador=int.Parse( Console.ReadLine());
                if (Jugador > 0 && Jugador<4) {
                    bot=Ebot();
                    Console.WriteLine("\nusted "+mostrar(Jugador,es));
                    Console.WriteLine("el bot "+mostrar(bot,es));
                    switch (gana(bot, Jugador))
                    {

                        case 0:
                            Console.WriteLine("\n\tempate\n");
                            break;
                        case 1:
                            Console.WriteLine("\n\tel bot gana esta vez\n");
                            Wb++;
                            break;
                        case 2:
                            Console.WriteLine("\n\tusted gana esta vez\n");
                            Wj++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("el numero que ingreso no corresponde con ninguna eleccion, no se realiza nada.");
                }

            }

            if (Wb==juegos)
            {
                Console.WriteLine("te gano el bot Tsssss");
            }
            else
            {
                Console.WriteLine("felicidades humillaste al bot");
            }

        }

        public static string mostrar(int i, string[] es)
        {
           string var="escojio -> "+es[i-1];

            return var;
        }
        //en esta funcion el bot escoje entre 1,2,3 aleatoriamente para competir con el jugador
        public static int Ebot()
        {
            int bot = 0;
            bot = new Random().Next(1, 4);

            return bot;
        }

        // en esta funcion se analiza que tiro cada uno y si gana el bot (1) o si gana el jugador (2) y (0) si es empate
        public static int gana(int bot, int jugador)
        {
            int gana = 0;

            if (bot==1  && jugador==2)
            {
                return 2;
            }
            else if(bot==1 && jugador==3)
            {
                return 1;

            }else if (bot == 2 && jugador==1)
            {
                return 1;

            }else if (bot == 2 && jugador == 3)
            {
                return 2;

            }else if (bot==3 && jugador==1)
            {
                return 2;
            }else if (bot == 3 && jugador == 2)
            {
                return 1;
            }


            return gana;
        }

    }
}
