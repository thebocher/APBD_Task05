using APBD_Task05.Entities.Devices;
using APBD_Task05.Entities.Interfaces;
using APBD_Task05.Logic;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Task05.Presentation.Controllers;

[ApiController]
[Route("devices")]
public class DeviceController
{
    private readonly IDeviceManager _deviceManager = DeviceManagerFactory.GetDatabaseDeviceManager();
    
    [HttpGet]
    public IResult GetAllDevices()
    {
        return Results.Ok(Database.Devices);
    }

    [HttpGet("{id}")]
    public IResult GetDevice(string id)
    {
        try
        {
            return Results.Ok(_deviceManager.GetDeviceById(id));
        }
        catch
        {
            return Results.NotFound();
        }
    }

    [HttpPost("smart-watches")]
    public IResult AddDevice(SmartWatch device)
    {
        _deviceManager.AddDevice(device);
        return Results.Ok(device);
    }
    [HttpPost("personal-computers")]
    public IResult AddDevice(PersonalComputer device)
    {
        _deviceManager.AddDevice(device);
        return Results.Ok(device);
    }
    [HttpPost("embedded-devices")]
    public IResult AddDevice(EmbeddedDevice device)
    {
        _deviceManager.AddDevice(device);
        return Results.Ok(device);
    }
    

    [HttpPut("smart-watches/{id}")]
    public IResult UpdateSmartWatch(string id, [FromBody] SmartWatch device)
    {
        _deviceManager.EditDeviceData(id, device);
        try
        {
            return Results.Ok(_deviceManager.GetDeviceById(id));
        }
        catch
        {
            return Results.NotFound();
        }
    }
    
    [HttpPut("personal-computers/{id}")]
    public IResult UpdatePersonalComputer(string id, [FromBody] PersonalComputer device)
    {
        _deviceManager.EditDeviceData(id, device);
        try
        {
            return Results.Ok(_deviceManager.GetDeviceById(id));
        }
        catch
        {
            return Results.NotFound();
        }
    }
    
    [HttpPut("embedded-devices/{id}")]
    public IResult UpdateEmbeddedDevice(string id, [FromBody] EmbeddedDevice device)
    {
        _deviceManager.EditDeviceData(id, device);
        try
        {
            return Results.Ok(_deviceManager.GetDeviceById(id));
        }
        catch
        {
            return Results.NotFound();
        }
    }

    [HttpDelete("{id}")]
    public IResult DeleteDevice(string id)
    {
        try
        {
            _deviceManager.RemoveDevice(id);
            return Results.Ok();
        }
        catch
        {
            return Results.NotFound();
        }
        
    }
}