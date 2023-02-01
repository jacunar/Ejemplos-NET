using SQLite;
using maui_app.Models;

namespace maui_app;

public class PersonRepository {
    string _dbPath;

    public string StatusMessage { get; set; }

    private SQLiteConnection _connection;

    private void Init() {
        if (_connection != null)
            return;

        _connection = new SQLiteConnection(_dbPath);
        _connection.CreateTable<Person>();
    }

    public PersonRepository(string dbPath) {
        _dbPath = dbPath;
    }

    public void AddNewPerson(string name) {
        int result = 0;
        try {
            Init();

            // basic validation to ensure a name was entered
            if (string.IsNullOrEmpty(name))
                throw new Exception("Valid name required");

            result = _connection.Insert(new Person { Name = name });
            
            StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, name);
        } catch (Exception ex) {
            StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
        }

    }

    public List<Person> GetAllPeople() {
        try {
            Init();
            return _connection.Table<Person>().ToList();
        } catch (Exception ex) {
            StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
        }

        return new List<Person>();
    }
}