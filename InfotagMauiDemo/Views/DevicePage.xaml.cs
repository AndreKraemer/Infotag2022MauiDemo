namespace InfotagMauiDemo.Views;

public partial class DevicePage : ContentPage
{
	public DevicePage()
	{
		InitializeComponent();
	}

    private void PlattformDeviceButtonClicked(object sender, EventArgs e)
    {
        var service = new DeviceService();
        FolderDeviceLabel.Text = service.GetDeviceName();
    }

    private void FileDeviceButtonClicked(object sender, EventArgs e)
    {
        var service = new Services.Device.DeviceService();
        FileDeviceLabel.Text = service.GetDeviceName();
    }
}