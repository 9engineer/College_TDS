namespace Lab_26
{
	public class Presenter
	{
		private readonly Model _model;

		public Presenter(Model model)
		{
			this._model = model;
		}

		public Model Login(string login, string password)
		{
			login = login.Trim();
			password = password.Trim();
			this._model.Login(login, password);
			return this._model;
		}
	}
}