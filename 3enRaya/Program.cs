using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3enRaya
{
    class Program
    {
        public static void Main(string[] args)
        {
            string opcion;
            do
            {
                ComenzarPartida();

                Console.WriteLine("Quieres jugar otra vez? | 1 = SI , ENTER = NO");
                opcion = Console.ReadLine();

            } while (opcion.Equals("1"));

            Console.WriteLine("Adios!");
            Console.ReadLine();
        }

        static int turno;
        static int[,] casilla = new int[3, 3];
        static bool winJ1 = false;
        static bool winJ2 = false;

        public static void ConstatarTablero()
        {
            for (int i = 0; i < casilla.GetLength(0); i++)
            {
                for (int j = 0; j < casilla.GetLength(1); j++)
                {
                    casilla[i, j] = 0;
                }
            }
        }
        public static void ComenzarPartida()
        {
            turno = 1;
            ConstatarTablero();
            while (!WinCondition())
            {
                MostrarTablero();
                Tirada();
            }
        }

        public static void Tirada()
        {

            string fila, columna;
            int columnaInt, filaInt;
            if (turno % 2 == 0)
            {
                Console.WriteLine("Turno del JUGADOR 2");
            }
            else Console.WriteLine("Turno del JUGADOR 1");

            do
            {

                do
                {
                    Console.WriteLine("En que fila quieres colocar tu ficha?");
                    fila = Console.ReadLine();
                    if (fila != "1" ^ fila != "2" ^ fila != "3")
                    {
                        Console.WriteLine("Esa fila no existe!");
                    }
                } while (fila != "1" ^ fila != "2" ^ fila != "3");

                do
                {
                    Console.WriteLine("En que columna quieres colocar tu ficha?");
                    columna = Console.ReadLine();
                    if (columna != "1" ^ columna != "2" ^ columna != "3")
                    {
                        Console.WriteLine("Esa columna no existe!");
                    }
                } while (columna != "1" ^ columna != "2" ^ columna != "3");

                columnaInt = Convert.ToInt32(columna) - 1;
                filaInt = Convert.ToInt32(fila) - 1;

                if (casilla[columnaInt, filaInt] != 1 ^ casilla[columnaInt, filaInt] != 4)
                {
                    Console.WriteLine("Esa casilla ya esta ocupada!");
                }

            } while (casilla[columnaInt, filaInt] != 1 ^ casilla[columnaInt, filaInt] != 4);


            if (turno % 2 == 0)
            {
                casilla[columnaInt, filaInt] = 4;
            }
            else
                casilla[columnaInt, filaInt] = 1;

            turno++;
        }

        public static void MostrarTablero()
        {
            string contCasilla1 = "0";
            string contCasilla2 = "0";
            string contCasilla3 = "0";
            Console.WriteLine("TURNO " + turno);
            Console.WriteLine("  |__1__|__2__|__3__");
            Console.WriteLine("1_|  " + casilla[0, 0] + "  |  " + casilla[1, 0] + "  |  " + casilla[2, 0]);
            Console.WriteLine("2_|  " + casilla[0, 1] + "  |  " + casilla[1, 1] + "  |  " + casilla[2, 1]);
            Console.WriteLine("3_|  " + casilla[0, 2] + "  |  " + casilla[1, 2] + "  |  " + casilla[2, 2]);

            // He intentado traducir los numeros a simbolos para que sea mas parecido al juego real pero he fallado en el intento :(

            //if (casilla [0, 0] == 1)
            //{
            //    contCasilla1 = "o";
            //}
            //else if (casilla[1, 0] == 1)
            //{
            //    contCasilla2 = "o";

            //}
            //else if (casilla[2, 0] == 1)
            //{
            //    contCasilla3 = "o";

            //}

            //if (casilla[0, 0] == 4)
            //{
            //    contCasilla1 = "x";
            //}
            //else if (casilla[1, 0] == 4)
            //{
            //    contCasilla2 = "x";

            //}
            //else if (casilla[2, 0] == 4)
            //{
            //    contCasilla3 = "x";

            //}
            //Console.WriteLine("1_|  " + contCasilla1 + "  |  " + contCasilla2 + "  |  " + contCasilla3);

            //contCasilla1 = "0";
            //contCasilla2 = "0";
            //contCasilla3 = "0";
            //if (casilla[0, 1] == 1)
            //{
            //    contCasilla1 = "o";
            //}
            //else if (casilla[1, 1] == 1)
            //{
            //    contCasilla2 = "o";

            //}
            //else if (casilla[2, 1] == 1)
            //{
            //    contCasilla3 = "o";

            //}

            //if (casilla[0, 1] == 4)
            //{
            //    contCasilla1 = "x";
            //}
            //else if (casilla[1, 1] == 4)
            //{
            //    contCasilla2 = "x";

            //}
            //else if (casilla[2, 1] == 4)
            //{
            //    contCasilla3 = "x";

            //}
            //Console.WriteLine("2_|  " + contCasilla1 + "  |  " + contCasilla2 + "  |  " + contCasilla3);
            //contCasilla1 = "0";
            //contCasilla2 = "0"; 
            //contCasilla3 = "0";
            //if (casilla[0, 2] == 1)
            //{
            //    contCasilla1 = "o";
            //}
            //else if (casilla[1, 2] == 1)
            //{
            //    contCasilla2 = "o";

            //}
            //else if (casilla[2, 2] == 1)
            //{
            //    contCasilla3 = "o";

            //}

            //if (casilla[0, 2] == 4)
            //{
            //    contCasilla1 = "x";
            //}
            //else if (casilla[1, 2] == 4)
            //{
            //    contCasilla2 = "x";

            //}
            //else if (casilla[2, 2] == 4)
            //{
            //    contCasilla3 = "x";

            //}
            //Console.WriteLine("3_|  " + contCasilla1 + "  |  " + contCasilla2 + "  |  " + contCasilla3);
        }

        static bool WinCondition()
        {
            int contadorCasillasLlenas = 0;
            for (int i = 0; i < casilla.GetLength(0); i++)
            {
                for (int j = 0; j < casilla.GetLength(1); j++)
                {
                    if (casilla[i, j] != 0)
                    {
                        contadorCasillasLlenas++;
                        if (contadorCasillasLlenas == 9)
                        {
                            MostrarTablero();
                            Console.WriteLine("LA PARTIDA ACABA EN EMPATE");
                            return true;
                        }
                    }
                }
            }

            //for recorriendo las casillas, 3 variables que guarden los valores de las 3 combinaciones posibles y a sumar
            if (casilla[0, 0] + casilla[0, 1] + casilla[0, 2] == 3 ||
                casilla[1, 0] + casilla[1, 1] + casilla[1, 2] == 3 ||
                casilla[2, 0] + casilla[2, 1] + casilla[2, 2] == 3 ||
                casilla[0, 0] + casilla[1, 0] + casilla[2, 0] == 3 ||
                casilla[0, 1] + casilla[1, 1] + casilla[2, 1] == 3 ||
                casilla[0, 2] + casilla[1, 2] + casilla[2, 2] == 3 ||
                casilla[0, 0] + casilla[1, 1] + casilla[2, 2] == 3 ||
                casilla[0, 2] + casilla[1, 1] + casilla[2, 0] == 3)
            {
                winJ1 = true;
                MostrarTablero();
                Console.WriteLine("GANA EL JUGADOR 1 EN " + turno + " TURNOS");
                return winJ1;
            }
            if (casilla[0, 0] + casilla[0, 1] + casilla[0, 2] == 12 ||
                casilla[1, 0] + casilla[1, 1] + casilla[1, 2] == 12 ||
                casilla[2, 0] + casilla[2, 1] + casilla[2, 2] == 12 ||
                casilla[0, 0] + casilla[1, 0] + casilla[2, 0] == 12 ||
                casilla[0, 1] + casilla[1, 1] + casilla[2, 1] == 12 ||
                casilla[0, 2] + casilla[1, 2] + casilla[2, 2] == 12 ||
                casilla[0, 0] + casilla[1, 1] + casilla[2, 2] == 12 ||
                casilla[0, 2] + casilla[1, 1] + casilla[2, 0] == 12)

            {
                winJ2 = true;
                MostrarTablero();
                Console.WriteLine("GANA EL JUGADOR 2" + turno + " TURNOS");
                return winJ2;
            }

            return false;
        }
    }
}