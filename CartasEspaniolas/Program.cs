// Clase 14 Ejercicio - Cartas españolas
// Gerardo Fabián Quispe

/*  Ejercicio de cartas españolas orientado a objetos:
    Cada carta tiene un número entre 1 y 12 (el 8 y el 9 no los incluimos) y 
    un palo (espadas, bastos, oros y copas).
    La baraja estará compuesta por un conjunto de cartas, 40 exactamente.

    Las operaciones que podrá realizar la baraja son:
    Barajar():
    Cambia de posición todas las cartas aleatoriamente.

    SiguienteCarta():
    Devuelve la siguiente carta que está en la baraja, cuando no haya más 
    o se haya llegado al final, se indica al usuario que no hay más cartas.

    CartasDisponibles():
    Indica el número de cartas que aún puede repartir.

    DarCartas(int cantidad):
    Dado un número de cartas que nos pidan, le devolveremos ese número de
    cartas (piensa que puedes devolver). En caso de que haya menos cartas 
    que las pedidas, no devolveremos nada pero debemos indicárselo al usuario.

    CartasMonton():
    Mostramos aquellas cartas que ya han salido, si no ha salido ninguna 
    indicárselo al usuario.

    MostrarBaraja():
    Muestra todas las cartas hasta el final. Es decir, si se saca una carta 
    y luego se llama al método, este no mostrara esa primera carta.

    Escribir un programa que dentro de un bucle vaya mostrando las opciones
    que querramos, por ejemplo:

        1 - Barajar
        2 - Mostrar siguiente carta
        3 - Mostrar cartas disponibles
        4 - Dar cartas
        5 - Mostrar cartas del monton
        6 - Mostrar baraja
        7 - Salir
 */

//Console.WriteLine("hola");
using CartasEspaniolas.Modelo;

Baraja Mazzo = new Baraja();

int opc = 0;
do
{
    Console.WriteLine("############### CARTAS ESPAÑOLAS ###############");
    Console.WriteLine("  1.  Barajar.");
    Console.WriteLine("  2.  Mostrar siguiente carta.");
    Console.WriteLine("  3.  Mostrar cartas disponibles.");
    Console.WriteLine("  4.  Dar cartas.");
    Console.WriteLine("  5.  Mostrar cartas del monton.");
    Console.WriteLine("  6.  Mostrar baraja.");
    Console.WriteLine("  7.  Salir.");
    Console.Write("  Eliga una opcion: ");
    opc = int.Parse(Console.ReadLine());

    Console.Clear();

    switch (opc)
    {
        case 1:
            Mazzo.Barajar();
            Console.WriteLine();
            break;
        case 2:
            Mazzo.SiguienteCarta();
            Console.WriteLine();
            break;
        case 3:
            Console.WriteLine($"Cartas dispnibles: {Mazzo.CartasDisponibles()}");
            Console.WriteLine();
            break;
        case 4:
            Console.Write("Cuantas Cartas quiere: ");
            int nroCartas = int.Parse(Console.ReadLine());
            Mazzo.DarCartas(nroCartas);
            Console.WriteLine();
            break;
        case 5:
            Console.WriteLine("\nCartas del Monton:");
            Mazzo.CartasMonton();
            Console.WriteLine();
            break;
        case 6:
            Mazzo.MostrarBaraja();
            Console.WriteLine();
            break;
        case 7:
            Console.WriteLine("\n  Hasta pronto...\n");
            break;
        default:
            Console.WriteLine("Opcion no Disponible...");
            Console.WriteLine();
            break;
    }

} while (opc != 7);


