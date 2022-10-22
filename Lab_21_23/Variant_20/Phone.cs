using System;

namespace Variant_2
{
	public enum Vendor
	{
		Apple, Samsung, Xiaomi 
	}

	internal interface IPhone
	{
		void Show();
	}
	public class Phone : IPhone
	{
		private readonly Vendor _vendor;
		private readonly string _model;
		private readonly long _imei;

		public Phone(Vendor vendor, string model, long imei)
		{
			_vendor = vendor;
			_model = model;
			_imei = imei;
		}

		public void Show()
		{
			Console.WriteLine("-- Phone --\n" +
			                  $"Vendor: {_vendor}\n" +
			                  $"Model: {_model}\n" +
			                  $"IMEI: {_imei}");
		}
	}
}