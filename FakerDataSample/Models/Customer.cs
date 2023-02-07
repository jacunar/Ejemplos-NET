﻿namespace FakerDataSample.Models; 
public class Customer {
    public int Id { get; set; }
    public string? ContactName { get; set; }
    public string? CompanyName { get; set; }
    public string? Phone { get; set; }
    public int AddressId { get; set; }
    public Address? Address { get; set; }
    //public IEnumerable<Order>? Orders { get; set; }
}