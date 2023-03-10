using CRUD_MVVM.ViewModels;

namespace CRUD_MVVM.Views;

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