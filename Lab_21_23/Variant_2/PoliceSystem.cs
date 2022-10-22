using System.Collections.Generic;

namespace Variant_2
{
	public class PoliceSystem
	{
		private readonly List<Observer> _observers;

		public PoliceSystem()
		{
			_observers = new List<Observer>();
		}

		public void AddObserver(Observer post) => _observers.Add(post);

		public void RemoveObserver(Observer post) => _observers.Remove(post);

		public void NotifyObservers(string message)
		{
			foreach (Observer post in _observers)
				post.ShowNotify(message);
		}
	}
}