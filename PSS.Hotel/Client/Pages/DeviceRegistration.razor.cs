using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using PSS.Hotel.Shared.Models;

namespace PSS.Hotel.Client.Pages;

public partial class DeviceRegistration
{
    string KeyPressed = "";
    [Inject]
    protected IJSRuntime? JsRuntime { get; set; }

    PSS.Hotel.Shared.Models.DeviceRegistration deviceRegistration = new PSS.Hotel.Shared.Models.DeviceRegistration();

    void JumpToLoginPage()
    {
        NavigationManager.NavigateTo("/Login");
    }
    void HandleSubmit()
    {

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
