using Coravel.Events.Interfaces;
using OSM.Core.Application.Models;

namespace OSM.Core.Application.Events
{
    public class UserCreated : IEvent
    {
        public User User { get; set; }

        public UserCreated(User user)
        {
            this.User = user;
        }
    }
}
