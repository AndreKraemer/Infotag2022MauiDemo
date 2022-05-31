namespace InfotagMauiDemo.Services.Device;

public class DeviceService
{
    public string GetDeviceName()
    {
        return Android.OS.Build.Model;
    }
}
