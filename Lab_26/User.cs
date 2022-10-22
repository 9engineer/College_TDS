namespace Lab_26
{
	public class User
	{
		private string _name;
		private readonly string _login;
		private readonly string _password;

		public User(string name, string login, string password)
		{
			_name = name;
			_login = login;
			_password = password;
		}

		public string GetLogin() => _login;
		public string GetPassword() => _password;
		
	}
}