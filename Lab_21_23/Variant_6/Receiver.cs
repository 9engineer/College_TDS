namespace Variant_6
{
	public class Receiver
	{
		private readonly int _a;
		private readonly int _b;
		private int _result = 0;
		
		public Receiver(int a, int b)
		{
			_a = a;
			_b = b;
		}

		public void Addition() => _result = _a + _b;

		public void Subtraction() => _result = _a - _b;

		public void Multiplication() => _result = _a * _b;

		public void Division() => _result = _a / _b;

		public int GetResult() => _result;
	}
}