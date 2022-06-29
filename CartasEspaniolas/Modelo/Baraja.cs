using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasEspaniolas.Modelo
{
    internal class Baraja
    {
        public List<int> Mazo { get; set; }
        public List<int> Monton { get; set; }

        public Baraja()
        {
            // Creamos el mazo de cartas españolas
            // del 01 - 10 son las de ORO = ♦.
            // del 11 - 20 son las de COPA = ♥.
            // del 21 - 30 son las de ESPADAS = ♠.
            // del 31 - 40 son las de PALO = ♣.
            Mazo = new List<int>();
            for (int i = 1; i <= 40; i++)
            {
                Mazo.Add(i);
            }

            Monton = new List<int>();
        }


        // Mezclamos las cartas.
        // Cambiamos de posición todas las cartas aleatoriamente.
        public void Barajar()
        {
            if (Mazo.Count() != 0) // Comporbamos que la baraja tenga almenos una carta
            {
                Random rand = new Random();
                for (int i = 0; i < Mazo.Count(); i++)
                {
                    int j = rand.Next(0, Mazo.Count());
                    int aux = Mazo[i];
                    Mazo[i] = Mazo[j];
                    Mazo[j] = aux;
                }
                Console.WriteLine("\nSe a mezclado la Baraja\n");
            }
            else
                Console.WriteLine("\nNo hay cartas para Barajar...");
        }

        // Devuelve la siguiente carta que está en la baraja,
        // cuando no hay más o se haya llegado al final, se indica
        // al usuario que no hay más cartas.
        public void SiguienteCarta()
        {
            if (Mazo.Count() != 0) // Comporbamos que la baraja tenga almenos una carta
                Console.WriteLine($"\nSiguiente Carta {Naipe(Mazo[Mazo.Count() - 1])}\n");
            else
                Console.WriteLine("\nNo hay más cartas...\n");
        }

        // Devuelve el número de cartas que aún puede repartir
        public int CartasDisponibles()
        {
            return Mazo.Count();
        }

        // Dado un número de cartas que nos pidan, le devolveremos ese número de cartas
        // En caso de que haya menos cartas que las pedidas, no devolveremos nada pero
        // le indicamos al usuario que no hay cartas suficientes.
        public void DarCartas(int cantidad)
        {
            int cantCartas = Mazo.Count();
            if (cantidad <= cantCartas) // Comprobamos que la cantidad de cartas pedidas no sea superior a las existentes
            {
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine($"Toma el {Naipe(Mazo[cantCartas - i - 1])}");
                    Monton.Add(Mazo[cantCartas - i - 1]);
                }
                RemoverCarta(cantidad);
            }
            else
                Console.WriteLine("\nNo se disponen de la cantidad de cartas solicitadas...\n");

        }

        // Eliminamos de la Baraja las cartas que se han pedido.
        public void RemoverCarta(int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Mazo.RemoveAt(Mazo.Count() - 1);
            }
        }

        // Mostramos aquellas cartas que ya han salido, si no ha salido
        // ninguna indicárselo al usuario.
        public void CartasMonton()
        {
            if (Monton.Count() != 0) // Comporbamos que el Monton tenga almenos una carta
            {
                for (int i = 0; i < Monton.Count(); i++)
                {
                    Console.Write($"  {Naipe(Monton[i])}");
                    if ((i + 1) % 10 == 0) Console.WriteLine();
                }
            }
            else
                Console.WriteLine("\nAun no a pedido ninguna carta...\n");

            Console.WriteLine();
        }

        // Muestra todas las cartas hasta el final.
        // Es decir, si se saca una carta y luego se llama al método,
        // este no mostrara esa primera carta.
        public void MostrarBaraja()
        {
            Console.WriteLine("\nBaraja:\n");
            if (Mazo.Count() != 0) // Comporbamos que la baraja tenga almenos una carta
            {
                for (int i = 0; i < Mazo.Count; i++)
                {
                    Console.Write($"  {Naipe(Mazo[i])}");
                    if ((i + 1) % 10 == 0) Console.WriteLine();
                }
            }
            else
                Console.WriteLine("No hay cartas para Mostrar...");

            Console.WriteLine();
        }


        // del 01 - 10 son las de ORO = ♦.
        // del 11 - 20 son las de COPA = ♥.
        // del 21 - 30 son las de ESPADAS = ♠.
        // del 31 - 40 son las de PALO = ♣.
        public string Naipe(int carta)
        {
            if (carta >= 1 && carta <= 10)
                return ($"{(carta % 10):00}_♦");
            else if (carta >= 11 && carta <= 20)
                return ($"{(carta % 10):00}_♥");
            else if (carta >= 21 && carta <= 30)
                return ($"{(carta % 10):00}_♠");
            else
                return ($"{(carta % 10):00}_♣");
        }
    }
}
