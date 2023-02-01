namespace maui_app;

public partial class App : Application {
	public App(TipCalculatorPage page) {
		InitializeComponent();

		MainPage = new NavigationPage(page);
	}
}