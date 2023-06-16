using ShoppingUI.MVVM.ViewModels;

namespace ShoppingUI.MVVM.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(ProductViewModel item)
	{
		InitializeComponent();
		BindingContext = item;
	}
}
