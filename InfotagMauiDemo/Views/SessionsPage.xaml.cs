using InfotagMauiDemo.ViewModels;

namespace InfotagMauiDemo.Views;

public partial class SessionsPage : ContentPage
{
    private readonly SessionsPageViewModel _viewModel;

    public SessionsPage(SessionsPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = _viewModel = viewModel;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.OnAppearing();
    }


}