using System;

namespace Variant_2
{
	internal static class Client
	{
		public static void Main(string[] args)
		{
			IFactory phonesApple = new FactoryApple();
			IPhone phone1 = phonesApple.CreatePhone();
			IFactory phonesSamsung = new FactorySamsung();
			IPhone phone2 = phonesSamsung.CreatePhone();
			phone1.Show();
			phone2.Show();
		}
	}
}