using APBD_Task05.Entities.Devices;
using APBD_Task05.Entities.Interfaces;
using APBD_Task05.Logic;

namespace APBD_Task05.Logic.DeviceManagers;

public class DatabaseDeviceManager : IDeviceManager
{
    public void AddDevice(Device device)
    {
        Database.Devices.Add(device);
    }

    public void RemoveDevice(string deviceId)
    {
        Database.Devices.Remove(GetDeviceById(deviceId));
    }

    public void EditDeviceData(string deviceId, Device data)
    {
        GetDeviceById(deviceId).Update(data);
    }

    public void SaveData()
    {
        throw new NotImplementedException();
    }

    public void TurnOnDevice(string deviceId)
    {
        throw new NotImplementedException();
    }

    public void TurnOffDevice(string deviceId)
    {
        throw new NotImplementedException();
    }

    public Device GetDeviceById(string deviceId)
    {
        return Database.Devices.First(d => d.Id == deviceId);
    }

    public void ShowAllDevices()
    {
        throw new NotImplementedException();
    }
}