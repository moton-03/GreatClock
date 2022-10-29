using Clock.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Clock.Views;

public sealed partial class ClockPage : Page
{
    public ClockViewModel ViewModel
    {
        get;
    }

    public ClockPage()
    {
        ViewModel = App.GetService<ClockViewModel>();
        InitializeComponent();

        TimeUpdata();
    }

    public async void TimeUpdata()
    {
        DateTime dt = DateTime.Now;

        TimeText.Text = dt.ToString();

        await Task.Delay(1);

        TimeUpdata();

    }
}
