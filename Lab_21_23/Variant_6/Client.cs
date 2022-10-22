using System;

namespace Variant_6
{
	internal static class Client
	{
		public static void Main(string[] args)
		{
			Invoker invoker = new Invoker();
			Receiver receiver = new Receiver(5, 5);
			AdditionCommand command = new AdditionCommand(receiver);
			invoker.SetCommand(command);
			invoker.Run();
			Console.WriteLine($"Result: {receiver.GetResult()}");
		}
	}
}