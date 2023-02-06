namespace maui_app;

public partial class App : Application {
	//public static PersonRepository PersonRepo { get; private set; }

	public App() {
		InitializeComponent();
		
		//PersonRepo = repo;
		MainPage = new AppShell();
	}
}