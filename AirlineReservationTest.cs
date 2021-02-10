using System;


class AirlineReservationTest
{
    static void Main()
    {
        AirlineReservation airlineReservation = new AirlineReservation();


        Console.WriteLine("\t<<<<<<<<<<Welcome on the New Airline's reservation system>>>>>>>>>>\n\n");

        Console.WriteLine("\n\nSeat availability:\n\n");
        
        airlineReservation.DisplayFirstClass();

        airlineReservation.DisplaySecondClass();


        do
        {
            Console.Write("\nPlease indicate what class would you like to travel on(1 or 2) or 0 to exit: ");
            int airlineReservationtheTravelChoice = int.Parse(Console.ReadLine());
            airlineReservation.SetTravelChoice(airlineReservationtheTravelChoice);

            if (airlineReservationtheTravelChoice == 1)
                airlineReservation.FirstClassBooking();
            else if (airlineReservationtheTravelChoice == 2)
                airlineReservation.SecondClassBooking();
            else if (airlineReservationtheTravelChoice == 0)
                break;
            else
            {
                Console.WriteLine("Your answer does not specify a valid choice.");
                continue;
            }

        } while (airlineReservation.GetTravelchoice() != 0);

        Console.WriteLine("\n\nSeat availability: \n\n");

        airlineReservation.DisplayFirstClass();

        airlineReservation.DisplaySecondClass();

        Console.WriteLine("\t\t\t<<<<<<<< Thank you for choosing to fly with us >>>>>>>>");

    }

}
