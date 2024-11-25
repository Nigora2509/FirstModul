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
            Console.WriteLine("2. Delete evnt");
            Console.WriteLine("3. Update event");
            Console.WriteLine("4. Get event By Id:");
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
                Console.Write(" Enter id to Delete: ");
                var id = Guid.Parse(Console.ReadLine());
                var dleteEvent = eventService.DeletedEvent(id);
               if (dleteEvent is false)
                {
                    Console.WriteLine(" This event is not Deleted,try again");
                }
                else
                {
                    Console.WriteLine("Event is deleted");
                }

            }
            else if (option == 3)
            {
                var newEvent = new Event();
                Console.Write(" Enter id to update: ");
                newEvent.Id = Guid.Parse(Console.ReadLine());
                Console.Write("Enter Title: ");
                newEvent.Title = Console.ReadLine();
                Console.Write("Enter Location:  ");
                newEvent.Location = Console.ReadLine();
                Console.Write("Enter Date : ");
                newEvent.EventDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter Description: ");
                newEvent.Description = Console.ReadLine();


                newEvent.AttendenceMembers = new List<string>();

                Console.Write("Enter  members : ");
                var count = int.Parse(Console.ReadLine());

                for (var i = 0; i < count; i++)
                {
                    Console.Write("Enter Attendence Members: ");
                    var members = Console.ReadLine();
                    newEvent.AttendenceMembers.Add(members);
                }

                Console.Write("Enter tags count: ");
                var countOfTags = int.Parse(Console.ReadLine());

                for (var i = 0; i < countOfTags; i++)
                {
                    Console.Write("Enter tagg: ");
                    var newTags = Console.ReadLine();
                    newEvent.Tags.Add(newTags);
                }

                var result = eventService.UpdatedEvent( newEvent);

                if (result is true)
                {
                    Console.WriteLine(" Successfully");
                }
                else
                {
                    Console.WriteLine(" Not updated ");
                }
            }
        }
    }
}
