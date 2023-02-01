namespace maui_app;

public partial class App : Application {
	public App(TipCalculatorv2 page) {
		InitializeComponent();

		MainPage = new NavigationPage(page);
	}
}