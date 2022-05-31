using System.Collections.ObjectModel;
using System.Windows.Input;
using InfotagMauiDemo.Models;
using InfotagMauiDemo.Services;
using InfotagMauiDemo.Views;

namespace InfotagMauiDemo.ViewModels
{
    public class SessionsPageViewModel : BaseViewModel
    {
        private readonly IDataService _dataService;

        private readonly ObservableCollection<Session> _sessions = new ObservableCollection<Session>();

        public SessionsPageViewModel(IDataService dataService)
        {
            _dataService = dataService;
            NavigateToDetailsCommand = new Command<Session>(NavigateToDetailsPage);
        }

        private void NavigateToDetailsPage(Session session)
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "Session", session }
            };
            Shell.Current.GoToAsync($"{nameof(SessionDetailPage)}", navigationParameter);
        }

        public ObservableCollection<Session> Sessions => _sessions;

        public ICommand NavigateToDetailsCommand { get; set; }

        public void OnAppearing()
        {
            _sessions.Clear();
            var sessions = _dataService.GetSessions();
            foreach (var session in sessions)
            {
                _sessions.Add(session);
            }
        }
    }
}
