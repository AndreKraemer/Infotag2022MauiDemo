namespace InfotagMauiDemo;

public class DeviceService
{
    public string GetDeviceName()
    {
        var deviceInformation = new Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation();
        return deviceInformation.FriendlyName;
    }
}
