namespace maui_app;

public partial class App : Application {
	public App(NotesPage page) {
		InitializeComponent();

		MainPage = new NavigationPage(page);
	}
}