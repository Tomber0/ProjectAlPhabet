using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ProjectAlPhabet.ModelView
{
    public partial class MainWindowModelView:ObservableObject
    {
        [ObservableProperty]
        private string _settingsTitle = "Show Settings";

        [RelayCommand]
        private async Task NextPictureAsync() 
        {
            throw new NotImplementedException();
        }

        [RelayCommand]
        private async Task PostPictureAsync() 
        {
            throw new NotImplementedException();
        }

        [RelayCommand]
        private async Task ShowSettingsAsync() 
        {
            throw new NotImplementedException();
        }


    }
}
