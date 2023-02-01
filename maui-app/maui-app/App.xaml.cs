namespace maui_app;

public partial class App : Application {
	public static PersonRepository PersonRepo { get; private set; }

	public App(PeoplePage page, PersonRepository repo) {
		InitializeComponent();

		PersonRepo = repo;
		MainPage = new NavigationPage(page);
	}
}