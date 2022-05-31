namespace InfotagMauiDemo.Services.Device;

public class DeviceService
{
    public string GetDeviceName()
    {
        return UIKit.UIDevice.CurrentDevice.Name;
    }
}
