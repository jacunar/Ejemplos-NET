namespace maui_app.Pages;

public partial class NotesPage : ContentPage {
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
    public NotesPage() {
		InitializeComponent();

        if (File.Exists(_fileName)) {
            editor.Text = File.ReadAllText(_fileName);
        }
    }

    private void OnSaveButtonClicked(object sender, EventArgs e) { }

    private void OnDeleteButtonClicked(object sender, EventArgs e) { }
}