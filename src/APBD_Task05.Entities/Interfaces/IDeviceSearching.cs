using APBD_Task05.Entities.Devices;

namespace APBD_Task05.Entities.Interfaces;

public interface IDeviceSearching
{
    public Device GetDeviceById(string deviceId);
}