﻿using SQLite;

namespace maui_app.Models;

[Table("people")]
public class Person {
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [MaxLength(250), Unique]
    public string Name { get; set; }
}