using System;

namespace Variant_17
{
	public enum Color
	{
		BlackWhite, FullColor
	}

	public abstract class Printer
	{
		protected string Model { get; }
		protected Color Color { get; }

		protected Printer(string model, Color color)
		{
			Model = model;
			Color = color;
		}

		public abstract void ShowPrint(string message);
	}

	// ReSharper disable once InconsistentNaming
	public class BW100 : Printer
	{
		public BW100() : base(
			model: "BW-100", color: Color.BlackWhite) { }

		public override void ShowPrint(string message)
		{
			Console.WriteLine($"Принтер {Model} | {Color} распечатал:\n\t" +
			                  $"{message}");
		}
	}
	// ReSharper disable once InconsistentNaming
	public class BA215 : Printer
	{
		public BA215() : base(
			model: "BA-215", color: Color.FullColor) { }

		public override void ShowPrint(string message)
		{
			Console.WriteLine($"Принтер {Model} | {Color} распечатал:\n\t" +
			                  $"{message}");
		}
	}
}