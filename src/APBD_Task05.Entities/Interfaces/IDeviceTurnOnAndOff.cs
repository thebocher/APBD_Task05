namespace APBD_Task05.Entities.Interfaces;

public interface IDeviceTurnOnAndOff
{
    public void TurnOnDevice(string deviceId);
    public void TurnOffDevice(string deviceId);
}