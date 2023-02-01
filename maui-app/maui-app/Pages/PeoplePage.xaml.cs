using maui_app.Models;

namespace maui_app.Pages;

public partial class PeoplePage : ContentPage {
    public PeoplePage() {
        InitializeComponent();
    }

    public void OnNewButtonClicked(object sender, EventArgs args) {
        statusMessage.Text = "";

        App.PersonRepo.AddNewPerson(newPerson.Text);
        statusMessage.Text = App.PersonRepo.StatusMessage;
    }

    public void OnGetButtonClicked(object sender, EventArgs args) {
        statusMessage.Text = "";

        List<Person> people = App.PersonRepo.GetAllPeople();
        peopleList.ItemsSource = people;
    }
}