using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input; 

namespace UFSJ.ViewModels
{
    public class FileViewModel : BaseViewModel
    {
        readonly string UpdateLocation = "aHR0cHM6Ly9naXRodWIuY29tL0dyZWVuRHJhZ29uZmx5U3R1ZGlvL1VGU0ovcmVsZWFzZXMvbGF0ZXN0";
        public FileViewModel()
        {
            AppUpdateCheck = new NotifyTaskCompletion<bool>(
                CheckForUpdateAsync(Convert.ToString(Convert.FromBase64String(UpdateLocation)))); 
        }

        public NotifyTaskCompletion<bool> AppUpdateCheck { get; private set; }

        public static async Task<bool> CheckForUpdateAsync(string url)
        {
            // Implement check for update here.
            return true;
        }
    }
}
