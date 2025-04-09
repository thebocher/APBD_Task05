namespace APBD_Task05.Entities.Exceptions;

public class DeviceNotFoundException : Exception
{
    public DeviceNotFoundException() : base("Device not found") { }
}