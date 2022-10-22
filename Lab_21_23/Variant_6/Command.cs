namespace Variant_6
{
	public abstract class Command
	{
		public abstract void Execute();
		public abstract void Undo();
	}

	public class MultiplicationCommand : Command
	{
		private readonly Receiver _receiver;
		
		public MultiplicationCommand(Receiver receiver)
		{
			_receiver = receiver;
		}
		public override void Execute()
		{
			_receiver.Multiplication();
		}

		public override void Undo()
		{
			throw new System.NotImplementedException();
		}
	}
	
	public class DivisionCommand : Command
	{
		private readonly Receiver _receiver;
		
		public DivisionCommand(Receiver receiver)
		{
			_receiver = receiver;
		}
		public override void Execute()
		{
			_receiver.Division();
		}

		public override void Undo()
		{
			throw new System.NotImplementedException();
		}
	}

	public class AdditionCommand : Command
	{
		private readonly Receiver _receiver;
		
		public AdditionCommand(Receiver receiver)
		{
			_receiver = receiver;
		}
		public override void Execute()
		{
			_receiver.Addition();
		}

		public override void Undo()
		{
			throw new System.NotImplementedException();
		}
	}

	public class SubtractionCommand : Command
	{
		private readonly Receiver _receiver;
		
		public SubtractionCommand(Receiver receiver)
		{
			_receiver = receiver;
		}
		public override void Execute()
		{
			_receiver.Subtraction();
		}

		public override void Undo()
		{
			throw new System.NotImplementedException();
		}
	}
}