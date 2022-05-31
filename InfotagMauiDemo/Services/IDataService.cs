using InfotagMauiDemo.Models;

namespace InfotagMauiDemo.Services
{
    public interface IDataService
    {
        Session GetSession(int id);
        IEnumerable<Session> GetSessions();
        Speaker GetSpeaker(int id);
        IEnumerable<Speaker> GetSpeakers();
    }
}