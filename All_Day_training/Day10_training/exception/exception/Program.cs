using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    class Passenger
    {
        public string Name;
        public int Age;
    }



    class MaxTicketsExceededException : Exception
    {
        public MaxTicketsExceededException(string message) : base(message)
        {
        }
    }



    class TicketBookingSystem
    {
        public void TicketBooking(int numberOfTickets)
        {
            if (numberOfTickets > 2)
            {
                throw new MaxTicketsExceededException("Cannot book more than 2 tickets.");
            }
            else
            {
                Console.WriteLine("Ticket Booked Successfully.");
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter passenger name: ");
                string passengerName = Console.ReadLine();



                Console.Write("Enter passenger age: ");
                int passengerAge = int.Parse(Console.ReadLine());



                Passenger passenger = new Passenger
                {
                    Name = passengerName,
                    Age = passengerAge
                };



                Console.Write("Enter the number of tickets to be booked: ");
                int numberOfTickets = int.Parse(Console.ReadLine());



                TicketBookingSystem ticketSystem = new TicketBookingSystem();
                ticketSystem.TicketBooking(numberOfTickets);



                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
            }
            catch (MaxTicketsExceededException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
            }

        }
    }
}