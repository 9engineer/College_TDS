using System;

namespace Variant_2
{
	internal static class Client
	{
		public static void Main(string[] args)
		{
			PoliceSystem system = new PoliceSystem();
			Console.Write("Введите кол-во постов: ");
			int countPosts = Int32.Parse(Console.ReadLine() ?? string.Empty);
			for (int i = 0; i < countPosts; i++)
			{
				Console.Write($"Введите имя {i + 1} поста: ");
				system.AddObserver(new Post(id: i + 1, name: Console.ReadLine()));
			}
			Console.Write("Введите сообщение: ");
			system.NotifyObservers(Console.ReadLine());
		}
	}
}