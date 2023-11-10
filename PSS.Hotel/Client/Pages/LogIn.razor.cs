namespace PSS.Hotel.Client.Pages;

public partial class LogIn
{
    string Message = string.Empty;

    EmployeeMaster employeeMaster = new EmployeeMaster();

    protected override async Task OnInitializedAsync()
    {
        await EmployeeMasterService.GetAll();
    }

    async Task HandleSubmit()
    {

        if (!string.IsNullOrWhiteSpace(employeeMaster.AliasName) && !string.IsNullOrWhiteSpace(employeeMaster.Password))
        {
            var result = await EmployeeMasterService.IsAuthoriezed(employeeMaster.AliasName!, employeeMaster.Password!);
            if (result)
            {
                NavigationManager.NavigateTo("/Index");
            }
            else
            {
                Message = "Wrong Username and Password ";
                NavigationManager.NavigateTo("/Login");

            }
        }
        else
        {
            Message = "Username and Password does not match";
        }
    }
}
