namespace checkbox;
public partial class MainPage : ContentPage {
    int count = 0;

    public MainPage(Exampleviewmodel exampleviewmodel) {
        InitializeComponent();
        BindingContext = exampleviewmodel;
    }
}
