namespace Variant_5
{
	public class User
	{
		public User(Factory factory)
		{
			CarModel1 = factory.CreateModel1();
			CarModel2 = factory.CreateModel2();
		}

		public Car CarModel1;
		public Car CarModel2;
	}
}