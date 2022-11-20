using MVVM_INPC.ViewModels;

namespace MVVM_INPC.Views;

public partial class ListPage : ContentPage
{
    ListPageViewModel vm;
    public ListPage(ListPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
        this.vm = vm;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        vm.GetPersonsCommand.Execute(null);
    }
}