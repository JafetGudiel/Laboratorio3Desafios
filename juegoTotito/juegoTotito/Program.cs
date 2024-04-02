using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoTotito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jugador = 2;
            int ingreso = 0;
            bool ingresoCorrecto = true;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
          

            // cambio de jugadores
            do
            {
                if (jugador == 2)
                {
                    jugador = 1;
                    SignoXoO(jugador, ingreso);

                } else if (jugador == 1)
                {
                    jugador = 2;
                    SignoXoO(jugador, ingreso);
                }
                Tablero();

                // Verificando que jugador gana
                #region
                char[] cadaSigno = { 'X', 'O' };
                foreach(char signo in cadaSigno)
                {
                    if ((VariablesJuego[0, 0] == signo) && (VariablesJuego[0, 1] == signo) && (VariablesJuego[0, 2] == signo)
                        || (VariablesJuego[1, 0] == signo) && (VariablesJuego[1, 1] == signo) && (VariablesJuego[1, 2] == signo)
                        || (VariablesJuego[2, 0] == signo) && (VariablesJuego[2, 1] == signo) && (VariablesJuego[2, 2] == signo)
                        || (VariablesJuego[0, 0] == signo) && (VariablesJuego[1, 0] == signo) && (VariablesJuego[2, 0] == signo)
                        || (VariablesJuego[0, 1] == signo) && (VariablesJuego[1, 1] == signo) && (VariablesJuego[2, 1] == signo)
                        || (VariablesJuego[0, 2] == signo) && (VariablesJuego[1, 2] == signo) && (VariablesJuego[2, 2] == signo)
                        || (VariablesJuego[0, 0] == signo) && (VariablesJuego[1, 1] == signo) && (VariablesJuego[2, 2] == signo)
                        || (VariablesJuego[0, 2] == signo) && (VariablesJuego[1, 1] == signo) && (VariablesJuego[2, 0] == signo))
                    {
                        if (signo == 'X')
                        {
                            Console.WriteLine(" ¡¡¡ Han ganado las 'X' !!!");
                        }
                        else
                        {
                            Console.WriteLine("¡¡¡ Han ganado las 'O' !!!");
                        }
                        Console.WriteLine("Presiona cualquier tecla para seguir jugando");
                        Console.Read();
                        ingreso = 0;
                        Reinicio();
                        break;
                    }

                    // empate 
                    else if (turnos == 10)
                    {
                        Console.WriteLine( "Ha sido un empate de ambos jugadores");
                        Console.WriteLine("Presiona cualquier tecla para seguir jugando");
                        Console.Read();
                        ingreso = 0;
                        Reinicio();
                        break;
                    }
                }

                #endregion

                //validacion del ingreso de los jugadores
                #region
                do
                {
                    Console.WriteLine("\n jugador {0} porfavor elige una casilla..", jugador);
                    try
                    {
                        ingreso = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("porfavor ingrese numeros");
                    }
                    if ((ingreso == 1) && (VariablesJuego[0, 0] == '1'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 2) && (VariablesJuego[0, 1] == '2'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 3) && (VariablesJuego[0, 2] == '3'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 4) && (VariablesJuego[1, 0] == '4'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 5) && (VariablesJuego[1, 1] == '5'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 6) && (VariablesJuego[1, 2] == '6'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 7) && (VariablesJuego[2, 0] == '7'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 8) && (VariablesJuego[2, 1] == '8'))
                        ingresoCorrecto = true;
                    else if ((ingreso == 9) && (VariablesJuego[2, 2] == '9'))
                        ingresoCorrecto = true;
                    else
                    {
                        Console.WriteLine("\n porfavor ingrese otro numero ");
                        ingresoCorrecto = false;
                    }

                } while (!ingresoCorrecto);
                #endregion

            } while (true);
        
        }
        // variables de array de inicio
        static char[,] VariablesJuego =
        {
            {'1', '2','3' },
            {'4', '5','6' },
            {'7', '8','9' }
        };

        // variables de arrays de reinicio
        static char[,] VariablesdeInicio =
        {
            {'1', '2','3' },
            {'4', '5','6' },
            {'7', '8','9' }
        };

        static int turnos = 0;

        //Metodo para crear el tablero
        public static void Tablero()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------- BIENVENIDOS AL JUEGO DE TOTITO ---------------------------------");
            Console.WriteLine("     |     |    ");
            Console.WriteLine(" {0}   |  {1}  |  {2}  ", VariablesJuego[0, 0], VariablesJuego[0, 1], VariablesJuego[0, 2]);
            Console.WriteLine("_____|_____|________");
            Console.WriteLine("     |     |    ");
            Console.WriteLine(" {0}   |  {1}  |  {2}  ", VariablesJuego[1, 0], VariablesJuego[1, 1], VariablesJuego[1, 2]);
            Console.WriteLine("_____|_____|________");
            Console.WriteLine("     |     |    ");
            Console.WriteLine(" {0}   |  {1}  |  {2}  ", VariablesJuego[2, 0], VariablesJuego[2, 1], VariablesJuego[2, 2]);
            Console.WriteLine("     |     |    ");
            turnos++;
        }

        // Signo del jugador
        public static void SignoXoO(int jugador, int ingreso)
        {
            char signo = ' ';
            if (jugador == 1)
            { signo = 'X'; }
            else if (jugador == 2)
            {
                signo = 'O';
            }
            switch (ingreso)
                 {
                   case 1: VariablesJuego[0, 0] = signo; break;
                   case 2: VariablesJuego[0, 1] = signo; break;
                   case 3: VariablesJuego[0, 2] = signo; break;
                   case 4: VariablesJuego[1, 0] = signo; break;
                   case 5: VariablesJuego[1, 1] = signo; break;
                   case 6: VariablesJuego[1, 2] = signo; break;
                   case 7: VariablesJuego[2, 0] = signo; break;
                   case 8: VariablesJuego[2, 1] = signo; break;
                   case 9: VariablesJuego[2, 2] = signo; break;
                   }
              
        }

        //Reinicio de tablero
        public static void Reinicio ()
        {
            VariablesJuego = VariablesdeInicio;
            Tablero();
            turnos = 0;
        }
    }
}
