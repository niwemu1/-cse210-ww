using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create sample addresses
        Address concertAddress = new Address("100 Main St", "Anytown", "CA", "USA");
        Address seminarAddress = new Address("200 Elm St", "Anothertown", "NY", "USA");

        // Create sample events
        Event concert = new ConcertEvent("Summer Jam", new DateTime(2024, 07, 15), concertAddress, "Big Artist");
        Event seminar = new SeminarEvent("Marketing Strategies", new DateTime(2024, 08, 10), seminarAddress, "Expert Speaker", "Growing Your Business");

        // Display marketing messages for each event
        Console.WriteLine(concert.GetEventNameMessage());
        Console.WriteLine(concert.GetEventDetailsMessage());
        Console.WriteLine("\n");

        Console.WriteLine(seminar.GetEventNameMessage());
        Console.WriteLine(seminar.GetEventDetailsMessage());
    }
}