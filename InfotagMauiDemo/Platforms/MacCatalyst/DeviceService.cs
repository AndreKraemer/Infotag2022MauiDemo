namespace InfotagMauiDemo;

public class DeviceService
{
    public string GetDeviceName()
    {
        return UIKit.UIDevice.CurrentDevice.Name;
    }
}
