using System.Xml.Linq;
using _9_dars.Models;
namespace _9_dars.Services
{
    public  class EventService
    {
        private List<Event> events;

        public EventService() 
        
        { 
           
             events  = new List<Event>();
            
          
         }

         public Event AddedEvent(Event addedEvent)
        {
            addedEvent.Id = Guid.NewGuid();

            events.Add(addedEvent);
         
            return addedEvent;

        }

        public Event GetById(Guid eventId)
        {
            foreach (var checkEvent in events)
            {
                if (checkEvent.Id == eventId)
                {
                    return checkEvent;
                }
                
            }
            return null;

        }
        public bool DeletedEvent(Guid eventId)
        {
            var deletedEvent = GetById(eventId);
            if (deletedEvent is null)
            { 
                return false;
            
            }
            events.Remove(deletedEvent);
            return true;
        }

        public bool UpdatedEvent( Event newEvent)
        { 
            var updatedEvent = GetById(newEvent.Id);
            if (updatedEvent is null)
            {
                return false;
            }
           var index = events.IndexOf(updatedEvent);
            events[index] = newEvent;
            return true;
        }

        public List<Event> GetAllEnets()
        {
            return events;
        }

        public List<Event> GetEventByLocation(string location)
        {
            var responseEvent = new List<Event>();
            foreach (var checkEvent in events)
            {
                if(checkEvent.Location == location)
                {
                    responseEvent.Add(checkEvent);
                }
            }

            return responseEvent;

        }

        public Event GetPopularEvent()
        {
            var popularEvent = new Event();
            var membersCount = 0;

            foreach (var checkEvent in events)
            {
                if (checkEvent.AttendenceMembers.Count > membersCount)
                {
                    membersCount = checkEvent.AttendenceMembers.Count;
                    popularEvent = checkEvent;
                }
            }

            return popularEvent;
        }

        public Event MaxTaggedEvent()
        {
            var maxTaggedEvent = new Event();
            var taggedCount = 0;
            foreach(var checkEvent in events)
            {
                if (checkEvent.Tags.Count > taggedCount)
                {
                    maxTaggedEvent = checkEvent;
                    taggedCount = checkEvent.Tags.Count;
                }
            }
            return maxTaggedEvent;
        }

        public bool AddPersonToEvent(Guid id, string name)
        {
            var addedPersonToEvent = GetById(id);
            if (addedPersonToEvent == null)
            {
                return false;
            }

            addedPersonToEvent.AttendenceMembers.Add(name);
            return true;

        }
  }
}
