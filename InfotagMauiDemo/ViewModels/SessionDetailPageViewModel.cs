using InfotagMauiDemo.Models;
using System.Windows.Input;
using InfotagMauiDemo.Services;

namespace InfotagMauiDemo.ViewModels
{
    [QueryProperty(nameof(Session), nameof(Session))]
    public class SessionDetailPageViewModel : BaseViewModel
    {
        public SessionDetailPageViewModel()
        {
            OpenTwitterCommand = new Command(OpenTwitter);
            CallSpeakerCommand = new Command(CallSpeaker);
        }

        public ICommand OpenTwitterCommand { get; set; }
        public ICommand CallSpeakerCommand { get; set; }
        public int SessionId { get; set; }

        private Session _session = new Session();
        public Session Session
        {
            get => _session;
            set => SetProperty(ref _session, value);
        }

        private void OpenTwitter()
        {
            Browser.OpenAsync(Session.Speaker.TwitterUrl);
        }

        private void CallSpeaker()
        {
            try
            {
                PhoneDialer.Open("12345678");
            }
            catch (FeatureNotSupportedException ex)
            {
                System.Diagnostics.Debug.WriteLine("Feature nicht untersützt");
            }
        }


    }
}
