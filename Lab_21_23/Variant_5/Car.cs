using System;

namespace Variant_5
{
	public enum ECar
	{
		Chevrolet, Ford
	}

	internal interface ICar
	{
		int GetSpeed();
		ECar GetVendor();
		void Go(string place);
		void Show();
	}
	
	public class Car : ICar
	{
		public Car(ECar vendor, int speedMax)
		{
			_vendor = vendor;
			_speedMax = speedMax;
		}

		private readonly ECar _vendor;
		private readonly int _speedMax;
		
		public int GetSpeed() => _speedMax;

		public ECar GetVendor() => _vendor;

		public void Go(string place) => Console.WriteLine($"{_vendor} went to {place}");

		public void Show() =>
			Console.WriteLine("-- Car --\n" +
			                  $"Vendor: {_vendor.ToString()}\n" +
			                  $"Speed: {_speedMax}");
	}
}