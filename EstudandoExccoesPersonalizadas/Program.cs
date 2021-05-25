using System;
using EstudandoExccoesPersonalizadas.Entities;

namespace EstudandoExccoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservation reservation = new Reservation(number, checkIn, checkOut);


            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            }
            else
            {
                Console.WriteLine("Reservation: " + reservation);
            }

            Console.WriteLine("Gostaria de atualizar sua reserva? s/n");
            string update = Console.ReadLine();
            if(update == "s" || update == "S")
            {
                Console.WriteLine("\nEnter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = reservation.UpdateDates(checkIn, checkOut);

                if(error != null)
                {
                    Console.WriteLine("Error in reservation: " + error);
                }
                else
                {
                    Console.WriteLine("Reservation: "+ reservation);
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
