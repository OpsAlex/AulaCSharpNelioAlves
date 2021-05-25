using System;
using EstudandoExccoesPersonalizadas.Entities;
using EstudandoExccoesPersonalizadas.Entities.Exceptions;

namespace EstudandoExccoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);

                Console.WriteLine("Gostaria de atualizar sua reserva? s/n");
                string update = Console.ReadLine();
                if (update == "s" || update == "S")
                {
                    Console.WriteLine("\nEnter data to update the reservation: ");
                    Console.Write("Check-in date (dd/MM/yyyy): ");
                    checkIn = DateTime.Parse(Console.ReadLine());
                    Console.Write("Check-out date (dd/MM/yyyy): ");
                    checkOut = DateTime.Parse(Console.ReadLine());

                    reservation.UpdateDates(checkIn, checkOut);

                    Console.WriteLine("Reservation: " + reservation);

                }

                else
                {
                    Console.WriteLine("Thanks for reservation");
                    Environment.Exit(0);
                }
            }
            catch (DomainExecption e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
        }
    }
}
