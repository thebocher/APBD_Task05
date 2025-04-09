using APBD_Task05.Entities.Devices;

namespace APBD_Task05.Entities.Interfaces;

public interface IDeviceModification
{
    public void AddDevice(Device device);
    public void RemoveDevice(string deviceId);
    public void EditDeviceData(String deviceId, Device data);
    public void SaveData();
}