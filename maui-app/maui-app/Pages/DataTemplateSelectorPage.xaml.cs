using maui_app.Models;

namespace maui_app.Pages;

public partial class DataTemplateSelectorPage : ContentPage {
    public DataTemplateSelectorPage() {
        InitializeComponent();
        List<PersonViewModel> people = new List<PersonViewModel> {
            new PersonViewModel { Name = "Kath", DateOfBirth = new DateTime(1985, 11, 20), Location = "France" },
            new PersonViewModel { Name = "Steve", DateOfBirth = new DateTime(1975, 1, 15), Location = "USA" },
            new PersonViewModel { Name = "Lucas", DateOfBirth = new DateTime(1988, 2, 5), Location = "Germany" },
            new PersonViewModel { Name = "John", DateOfBirth = new DateTime(1976, 2, 20), Location = "USA" },
            new PersonViewModel { Name = "Tariq", DateOfBirth = new DateTime(1987, 1, 10), Location = "UK" },
            new PersonViewModel { Name = "Jane", DateOfBirth = new DateTime(1982, 8, 30), Location = "USA" },
            new PersonViewModel { Name = "Tom", DateOfBirth = new DateTime(1977, 3, 10), Location = "UK" }
        };

        collectionView.ItemsSource = people;
    }
}