using InfotagMauiDemo.Views;

namespace InfotagMauiDemo;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(SessionDetailPage), typeof(SessionDetailPage));
    }
}
