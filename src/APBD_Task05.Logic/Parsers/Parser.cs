using APBD_Task05.Entities.Devices;

namespace APBD_Task05.Logic.Parsers;

public interface IParser
{
    public bool CanParse(string s);
    public Device Parse(string s);
}