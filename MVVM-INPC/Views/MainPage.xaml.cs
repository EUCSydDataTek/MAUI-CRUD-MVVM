using MVVM_INPC.ViewModels;

namespace MVVM_INPC.Views;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}


