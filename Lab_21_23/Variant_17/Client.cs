using System;

namespace Variant_17
{
	internal static class Client
	{
		public static void Main(string[] args)
		{
			Printer printer = new BW100();
			printer.ShowPrint("Hello, World!");
			printer = new BA215();
			printer.ShowPrint("Hello, Europe!");
			
		}
	}
}