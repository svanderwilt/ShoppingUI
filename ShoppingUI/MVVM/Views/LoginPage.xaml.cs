using ShoppingUI.MVVM.ViewModels;

namespace ShoppingUI.MVVM.Views;

public partial class LoginPage : ContentPage
{
    Entry PasswordEntry = new Entry();
	public LoginPage()
	{
		InitializeComponent();
		this.BindingContext = new LoginViewModel(this.Navigation);
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        PasswordEntry.IsEnabled = false;
        PasswordEntry.IsEnabled = true;
    }
}
