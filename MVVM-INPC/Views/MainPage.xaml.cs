using MVVM_INPC.ViewModels;

namespace MVVM_INPC.Views;

public partial class MainPage : ContentPage
{
	MainPageViewModel vm;

    public MainPage(MainPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		this.vm = vm;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        vm.OnPropertyChanged(nameof(vm.ThePerson)); // Refresh the binding to ThePerson-object
    }
}

