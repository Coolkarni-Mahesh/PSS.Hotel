using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace PSS.Hotel.Client.Pages;

public partial class DeviceRegistration
{
    string? ErrorMessage;
    string KeyPressed = "";
    [Inject]
    protected IJSRuntime? JsRuntime { get; set; }

    PSS.Hotel.Shared.Models.DeviceRegistration deviceRegistration = new PSS.Hotel.Shared.Models.DeviceRegistration();

    async Task HandleSubmit()
    {
        //192.168.29.23

        if (string.IsNullOrWhiteSpace(deviceRegistration.Username) && string.IsNullOrWhiteSpace(deviceRegistration.ServerIPAddress))
        {
            ErrorMessage = "* All Fileds are mandatory";
        }
        else if (deviceRegistration.ServerIPAddress != "127.0.0.1")
        {
            ErrorMessage = "* Enter Proper Server IP Address";
        }
        else
        {
            await DeviceRegistrationService.Add(deviceRegistration);
            NavigationManager.NavigateTo("/Login");
        }
    }

    protected override async Task OnInitializedAsync()
    {

        // First check local storag having data
        // if having any record then go to directly login page
        // else show server page for registration

        var k = await DeviceRegistrationService.GetAll();
        if (k != null && k.Count > 0)
        {
            NavigationManager.NavigateTo("/Login");
        }
    }

    void Tab(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {

            e.Key = "Tab";
        }
    }
    public void keydown(Microsoft.AspNetCore.Components.Web.KeyboardEventArgs args)
    {
        KeyPressed = "Key Pressed is " + args.Key;
        if (args.Key == "Enter")
        {
            JsRuntime?.InvokeVoidAsync("onFocus", "txtUserName");
        }
    }





}
