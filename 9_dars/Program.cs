using _9_dars.Models;
using _9_dars.Services;
namespace _9_dars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunFrontEnd();
        }
    }
    public static void RunFontEnd()
    {
        var eventService = new EventService();
        while (true)
        {
            Console.WriteLine("1. Add event");
            Console.WriteLine("2. Get Event by ID");
            Console.WriteLine("3. Delete event");
            Console.WriteLine("4. Update event");
            Console.WriteLine("5. Get all events");
            Console.WriteLine("6. Get events by location");
            Console.WriteLine("7. Get popular events");
            Console.WriteLine("8. Get Max tagged event");
            Console.Write("Enter  option : ");
            var option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                var addedEvent = new Event();
                Console.Write("Enter Title : ");
                addedEvent.Title = Console.ReadLine();
                Console.Write("Enter Location : ");
                addedEvent.Location = Console.ReadLine();
                Console.Write("Enter Date time : ");
                addedEvent.EventDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter Description : ");
                addedEvent.Description = Console.ReadLine();

                Console.Write(" Enter count of members: ");
                var countOfMembers = int.Parse(Console.ReadLine());
                for (var i = 0; i < countOfMembers; i++)
                {
                    Console.Write("Enter member neme: ");
                    var name = Console.ReadLine();
                    addedEvent.AttendenceMembers.Add(name);
                }

                Console.Write("Enter taggs count : ");
                var countOfTaggs = int.Parse(Console.ReadLine());

                for (var i = 0; i < countOfTaggs; i++)
                {
                    Console.Write("Enter tagg >> ");
                    var newTag = Console.ReadLine();
                    addedEvent.Tags.Add(newTag);
                }

                eventService.AddedEvent(addedEvent);
            }
            else if (option == 2)
            {
                Console.Write(" Enter id: ");
                var id = Guid.Parse(Console.ReadLine());
                var getEvent = eventService.GetById(id);
                string info = $

            }
        }
    }
}
