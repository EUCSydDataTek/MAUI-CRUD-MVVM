using CRUD_MVVM.ViewModels;

namespace CRUD_MVVM.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}