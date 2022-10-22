using System;

namespace Variant_3
{
	public enum Gender
	{
		Male, Female
	}

	public abstract class Document
	{
		public abstract void ShowDocument();
	}
	public class Passport : Document
	{
		public Passport(long identification, string country, string firstName, string lastName, Gender sex)
		{
			_identification = identification;
			_country = country;
			_firstName = firstName;
			_lastName = lastName;
			_sex = sex;
		}

		private readonly string _firstName;
		private readonly string _lastName;
		private readonly Gender _sex;
		private readonly string _country;
		private readonly long _identification;
		
		public override void ShowDocument()
		{
			Console.WriteLine("--- Паспорт ---\n" +
			                  $"ID-гражданина: {_identification}\n" +
			                  $"Имя: {_firstName}\nФамилия: {_lastName}\n" +
			                  $"Пол: {_sex}\nСтрана: {_country}");
		}
	}

	public abstract class DocumentDecorator : Document
	{
		private readonly Document _document;

		protected DocumentDecorator(Document document)
		{
			_document = document;
		}

		public override void ShowDocument()
		{
			_document.ShowDocument();
		}
	}
	public class CreditCard : DocumentDecorator
	{
		public CreditCard(Document document, string bank, long number, int cvv) : base(document)
		{
			_bank = bank;
			_number = number;
			_cvv = cvv;
		}

		private readonly string _bank;
		private readonly long _number;
		private readonly int _cvv;

		public override void ShowDocument()
		{
			base.ShowDocument();
			Console.WriteLine("--- Банковская карта ---\n" +
			                  $"Номер счета: {_number}\n" +
			                  $"Банк: {_bank} | CVV: {_cvv}");
		}
	}
	public class DriverLicense : DocumentDecorator
	{
		public DriverLicense(Document document, string type) : base(document)
		{
			_type = type;
		}
		private readonly string _type;
		public override void ShowDocument()
		{
			base.ShowDocument();
			Console.WriteLine("--- Водительские права ---\n" +
			                  $"Категория: {_type}");
		}
	}
}