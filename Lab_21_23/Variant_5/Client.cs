namespace Variant_5
{
	internal static class Client
	{
		public static void Main(string[] args)
		{
			User user1 = new User(new FactoryChevrolet());
			user1.CarModel1.Show();
			user1.CarModel1.Go("Minsk");
			user1.CarModel2.Show();

			User user2 = new User(new FactoryFord());
			user2.CarModel1.Show();
			user2.CarModel2.Go("Vitebsk");
			user2.CarModel2.Show();
		}
	}
}