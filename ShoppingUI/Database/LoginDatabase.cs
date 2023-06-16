using System;
using ShoppingUI.MVVM.Models;
using SQLite;

namespace ShoppingUI.Database
{
	public class LoginDatabase
	{
		readonly SQLiteAsyncConnection database;

		public LoginDatabase(string dbpath)
		{
			database = new SQLiteAsyncConnection(dbpath);
			database.CreateTableAsync<LoginModel>().Wait();
		}

		public Task<LoginModel> GetLoginDataAsync(string username)
		{
			return database.Table<LoginModel>().Where(x => x.Username == username).FirstOrDefaultAsync();
		}

		public Task<int> SaveLoginDataAsync(LoginModel loginData)
		{
			return database.InsertAsync(loginData);
		}
	
	}
}

