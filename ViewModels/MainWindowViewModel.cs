namespace GetStartedApp.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
#pragma warning disable CA1822 // Mark members as static
    public string Greeting => "Welcome to Avalonia! This is my added text. What's the problem?";
#pragma warning restore CA1822 // Mark members as static
}
