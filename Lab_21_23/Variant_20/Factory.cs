namespace Variant_2
{
	internal interface IFactory
	{
		Phone CreatePhone();
	}
	public class FactoryApple : IFactory
	{
		public Phone CreatePhone()
		{
			return new Phone(
				vendor: Vendor.Apple,
				model: "iPhone 13",
				imei: 998612085127419);
		}
	}
	public class FactorySamsung : IFactory
	{
		public Phone CreatePhone()
		{
			return new Phone(
				vendor: Vendor.Samsung,
				model: "Galaxy S20",
				imei: 450999120056328);
		}
	}
	public class FactoryXiaomi : IFactory
	{
		public Phone CreatePhone()
		{
			return new Phone(
				vendor: Vendor.Xiaomi,
				model: "Redmi Note 8",
				imei: 458599579907609);
		}
	}
}