namespace InfotagMauiDemo.Services.Device;

public class DeviceService
{
    public string GetDeviceName()
    {
        var deviceInformation = new Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation();
        return deviceInformation.FriendlyName;
    }
}
