using Microsoft.AspNetCore.Components;

namespace PSS.Hotel.Client.Pages;

public partial class LogIn
{
    EmployeeMaster _employeeMaster = new EmployeeMaster();
    string Message = "Loading...";
    protected override async Task OnInitializedAsync()
    {
        try
        {
            await EmployeeMasterService.GetAll();
            await DataService.GetAll();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error in OnInitializedAsync()" + ex);
        }
    }
    async Task HandleSubmit()
    {
        try
        {
            if (!string.IsNullOrWhiteSpace(_employeeMaster.AliasName) && !string.IsNullOrWhiteSpace(_employeeMaster.Password))
            {
                var result = await EmployeeMasterService.IsAuthoriezed(_employeeMaster.AliasName!, _employeeMaster.Password!);
                if (result)
                {
                    NavigationManager.NavigateTo("/Index");
                }
                else
                {
                    Message = "User not found";
                    NavigationManager.NavigateTo("/Login");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro in Login - HandleSubmit()" + ex);
        }
    }
}
