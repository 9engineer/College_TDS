using System;

namespace Variant_2
{
	public abstract class Observer
	{
		public abstract void ShowNotify(string message);
	}
	public class Post : Observer
	{
		private readonly int _id;
		private readonly string _name;
		
		public Post(int id, string name)
		{
			_id = id;
			_name = name;
		}

		public override void ShowNotify(string message)
		{
			Console.WriteLine($"\n-- Пост ГАИ №{_id}: {_name} -- \n" +
			                  $"Получено сообщение: {message}");
		}
	}
}