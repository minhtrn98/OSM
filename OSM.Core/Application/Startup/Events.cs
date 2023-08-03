using Coravel;
using Coravel.Events.Interfaces;
using OSM.Core.Application.Events;
using OSM.Core.Application.Events.Listeners;

namespace OSM.Core.Application.Startup
{
    public static class Events
    {
        public static IServiceProvider RegisterEvents(this IServiceProvider services)
        {
            IEventRegistration registration = services.ConfigureEvents();

            // add events and listeners here
            registration
                .Register<UserCreated>()
                .Subscribe<EmailNewUser>();

            return services;
        }
    }
}
