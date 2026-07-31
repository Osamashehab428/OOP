using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_and_Problem_Solving
{
    internal class Movie
    {
        public int MovieId;
        public string MovieTitle;
        public int AvailableSeats;
        public int TicketPrice;

         
        public Movie(int MovieId,string MovieTitle,int AvailableSeats,int TicketPrice)
        {
            this.MovieId  = MovieId;
            this.MovieTitle = MovieTitle;
            this.AvailableSeats = AvailableSeats;
            this.TicketPrice = TicketPrice;
        }

        public void BookTicket(int numbOfTickets)
        {
            if (numbOfTickets <= 0) { Console.WriteLine("Invalid number .... ");return; }
            if (AvailableSeats < numbOfTickets)
            {
                Console.WriteLine("Not enough seats .... ");
                return;
            }
            AvailableSeats -= numbOfTickets;

            Console.WriteLine("Booking completed successfully ...... ");
        }



        public override string ToString() 
        {
            return $"  Movie Title: {MovieTitle}\n Movie ID: {MovieId}\n Available Seats: {AvailableSeats}\n ticket Price: {TicketPrice}\n";
            
        }

        public void CancelTicket(int numberOfCancelledTickets)
        {
            if (numberOfCancelledTickets <= 0) { Console.WriteLine("Invalid Number .....");return; }
            AvailableSeats += numberOfCancelledTickets;

            Console.WriteLine("Ticket Cancelled successfully .... ");
        }


    }

    
}
