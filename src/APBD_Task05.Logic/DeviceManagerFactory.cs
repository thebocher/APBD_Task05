using APBD_Task05.Entities.Interfaces;
using APBD_Task05.Logic.DeviceManagers;

namespace APBD_Task05.Logic;

public class DeviceManagerFactory
{
    public static IDeviceManager GetFileDeviceManager(string filePath)
    {
        return new FileDeviceManager(filePath);
    }

    public static IDeviceManager GetDatabaseDeviceManager()
    {
        return new DatabaseDeviceManager();
    }
}