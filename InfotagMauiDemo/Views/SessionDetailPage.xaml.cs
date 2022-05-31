using InfotagMauiDemo.ViewModels;

namespace InfotagMauiDemo.Views;

public partial class SessionDetailPage : ContentPage
{
	public SessionDetailPage(SessionDetailPageViewModel viewmodel)
	{
		InitializeComponent();
		BindingContext = viewmodel;
	}
}