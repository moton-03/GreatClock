using Clock.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Clock.Views;

public sealed partial class DatePage : Page
{
    public DateViewModel ViewModel
    {
        get;
    }

    public DatePage()
    {
        ViewModel = App.GetService<DateViewModel>();
        InitializeComponent();
    }
}
