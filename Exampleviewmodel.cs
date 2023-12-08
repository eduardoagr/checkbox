using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace checkbox;
public partial class Exampleviewmodel() : ObservableObject {

    [ObservableProperty]
    ExampleUser exampleUser = new();

    [RelayCommand]
    void HandleChanges() {

        Shell.Current.DisplayAlert("info", ExampleUser.IsInvited.ToString(), "OK");
    }
}
