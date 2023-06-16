using ShoppingUI.MVVM.ViewModels;

namespace ShoppingUI.MVVM.Views;

public partial class ProductPage : ContentPage
{
	public ProductPage()
	{
		InitializeComponent();
        this.BindingContext = new ProductViewModel(this.Navigation);
    }

    void ListView_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
        Console.WriteLine("I got clicked");
    }
}
