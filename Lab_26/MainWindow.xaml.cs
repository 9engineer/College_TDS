using System.Windows;

namespace Lab_26
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow
	{
		private Model _model;
		private Presenter _presenter;
		
		public MainWindow()
		{
			InitializeComponent();
			_model = new Model();
			_presenter = new Presenter(_model);
		}

		private void UpdateMessage()
		{
			StatusMessage.Text = _model.GetMessageAuth();
		}
		private void LoginButton_OnClick(object sender, RoutedEventArgs e)
		{
			_model = _presenter.Login(LoginTextBox.Text, PasswordTextBox.Text);
			UpdateMessage();
		}
	}
}