using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ShoppingUI.MVVM.Models;
using ShoppingUI.MVVM.Views;

namespace ShoppingUI.MVVM.ViewModels
{
	public class ProductViewModel
	{
		public ObservableCollection<Product> Products { get; set; }

		public ObservableCollection<Product> CartProducts { get; set; }

		public Product SelectedProduct { get; set; }

		public ICommand ProductClick { get; set; }

		public ICommand CartProductClick { get; set; }

		public ProductViewModel(INavigation navigation)
		{
            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Picture="watch.png",
                    Name = "Cool Watch",
                    Quantity = "1",
                    Price = "$99"
                },
                new Product
                {
                    Picture="divingwatch.png",
                    Name = "Diving Watch",
                    Quantity = "1",
                    Price = "$89"
                },
                new Product
                {
                    Picture="dresswatch.png",
                    Name = "Dress Watch",
                    Quantity = "1",
                    Price = "$85"
                },
                new Product
                {
                    Picture="militarywatch.png",
                    Name = "Military Watch",
                    Quantity = "1",
                    Price = "$99"
                },
                new Product
                {
                    Picture="wristwatch.png",
                    Name = "Wrist Watch",
                    Quantity = "1",
                    Price = "$85"
                },
                new Product
                {
                    Picture="militarywatch.png",
                    Name = "Army Watch",
                    Quantity = "1",
                    Price = "$99"
                }
            };

            CartProducts = new ObservableCollection<Product> { };

            ProductClick = new Command<Product>(executeProductClickCommand);

            CartProductClick = new Command<Product>(executeCartProductClickCommand);

            this.navigation = navigation;
        }
        private INavigation navigation;

        async void executeProductClickCommand(Product item)
        {
            Console.WriteLine("I'm clicking the product!");
            this.SelectedProduct = item;
            await navigation.PushModalAsync(new DetailsPage(this));
        }

        async void executeCartProductClickCommand(Product item)
        {
            this.CartProducts.Add(this.SelectedProduct);
            //await navigation.PushModalAsync(new CartPage(this));

        }
    }
}


