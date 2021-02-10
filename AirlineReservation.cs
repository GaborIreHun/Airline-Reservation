using System;


class AirlineReservation
{
        
    bool[] firstClass = new bool[5];
    bool[] secondClass = new bool[5];
    public int travelClass;
    public int seatsTwo;
    public int seats;

    public void SetTravelChoice(int airlineReservationTravelClass)
    {
        travelClass = airlineReservationTravelClass;
    }

    public int GetTravelchoice()
    {
        return travelClass;
    }

    public void FirstClassBooking()
    {
        for (seats = 0; seats < firstClass.Length; seats++)
        {
            if (firstClass[4] == true && secondClass[4] == true)
            {
                Console.WriteLine("\n\n\t\t!!! Sorry, this flight is full !!!");
                travelClass = 0;
                break;
            }
            else if (firstClass[4] == true)
            {
                Console.WriteLine("\nThe first class has no more vacant seat, would you consider seat on the 2nd class? y or n: ");
                string decision = Console.ReadLine();
                if (decision == "y")
                {
                    Console.WriteLine("You were transfered to the second class.");
                    SecondClassBooking();
                    break;
                }
                else
                {
                    Console.WriteLine("\nNext flight leaves in 3 hours.");
                    break;
                }
            }
            else if (firstClass[seats] == true)
            {
                continue;
            }
            else if (firstClass[seats] != true)
            {
                firstClass[seats] = true;
                Console.WriteLine("Your reservation was made on the first class");
                break;
            }
            else
            {
                Console.WriteLine("Your answer does not specify a valid choice.");
                break;
            }
        }
        
    }


    public void SecondClassBooking()
    {
        for (seatsTwo = 0; seatsTwo < secondClass.Length; seatsTwo++)
        {
            if (firstClass[4] == true && secondClass[4] == true)
            {
                Console.WriteLine("\n\n\t\t!!! Sorry, this flight is full !!!");
                travelClass = 0;
                break;
            }
            else if (secondClass[4] == true)
            {
                Console.WriteLine("\nThe second class has no more vacant seat, would you consider seat on the 2nd class? y or n: ");
                string decision = Console.ReadLine();
                if (decision == "y")
                {
                    Console.WriteLine("You were transfered to the first class.");
                    FirstClassBooking();
                    break;
                }
                else
                {
                    Console.WriteLine("\nNext flight leaves in 3 hours.");
                    break;
                }
            }
            else if (secondClass[seatsTwo] == true)
            {
                continue;
            }
            else if (secondClass[seatsTwo] != true)
            {
                secondClass[seatsTwo] = true;
                Console.WriteLine("Your reservation was made on the second class.");
                break;
            }
            else
            {
                Console.WriteLine("\nYour answer does not specify a valid choice.");
                break;
            }
        }
    }

    public void DisplayFirstClass()
    {
        for (int i = 0; i < firstClass.Length; i++)
        {
            if (firstClass[i] == true)
            {
                Console.WriteLine($"Seat {i + 1} is occupied");
            }
            else
                Console.WriteLine($"Seat {i + 1} is vacant");   
        }
        Console.WriteLine("");
    }

    public void DisplaySecondClass()
    {
        for (int j = 0; j < secondClass.Length; j++)
        {
            if (secondClass[j] == true)
            {
                Console.WriteLine($"Seat {j + 6} is occupied");
            }
            else
                Console.WriteLine($"Seat {j + 6} is vacant");
        }
        Console.WriteLine(" ");
    }

}



