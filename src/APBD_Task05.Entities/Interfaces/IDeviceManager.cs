namespace APBD_Task05.Entities.Interfaces;

public interface IDeviceManager : IDeviceModification, IDeviceTurnOnAndOff, IDeviceSearching
{
    public void ShowAllDevices();
}