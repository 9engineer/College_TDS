namespace Variant_3
{
	internal static class Client
	{
		public static void Main(string[] args)
		{
			Document user = new Passport(
				identification: 6940396030,
				country: "Беларусь",
				firstName: "Павел",
				lastName: "Смирнов",
				sex: Gender.Male
			);
			user = new CreditCard(
				document: user,
				bank: "Приорбанк",
				number: 24055944465783056,
				cvv: 475);
			user.ShowDocument();
			user = new DriverLicense(
				document: user,
				type: "B");
			user.ShowDocument();
		}
	}
}