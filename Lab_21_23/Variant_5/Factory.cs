namespace Variant_5
{
	public abstract class Factory
	{
		public abstract Car CreateModel1();
		public abstract Car CreateModel2();
	}
	public class FactoryChevrolet : Factory
	{
		public override Car CreateModel1() => new Car(ECar.Chevrolet, 310);
		public override Car CreateModel2() => new Car(ECar.Chevrolet, 315);
	}

	public class FactoryFord : Factory
	{
		public override Car CreateModel1() => new Car(ECar.Ford, 320);
		public override Car CreateModel2() => new Car(ECar.Ford, 315);
	}
}