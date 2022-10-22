using System.Collections.Generic;
using System.Linq;

namespace Lab_26
{
	public class Model
	{
		private List<User> _users;
		private User _logged = null;
		
		public Model()
		{
			_users = new List<User>();
			_users.Add(new User(
				name: "Ермолай Ярославович",
				login:"ErmolayRedkiy516",
				password:"RLYQ5vlOq76S"));
			_users.Add(new User(
				name: "Валентина Юрьевна",
				login:"ValentinaIchetkina794",
				password:"j3LimKCdhDdg"));
			_users.Add(new User(
				name: "Петр Олегович",
				login:"PetrKropotov196",
				password:"3edJ4F7SxAjG"));
		}

		public void Login(string login, string password)
		{
			foreach (var user in _users.Where(user => login == user.GetLogin()
			         && password == user.GetPassword()))
			{
				_logged = user;
				break;
			}
		}
		public string GetMessageAuth() =>
			_logged != null
				? "Авторизация произошла успешно, " +
				  $"{_logged.GetLogin()}" : "⚠️ Неверный логин или пароль!";
	}
}