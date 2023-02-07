using Bogus;
using Bogus.Extensions;
using FakerDataSample.Models;

namespace FakerDataSample.Helper; 
public class CustomerFaker : Faker<Customer> {
    AddressFaker addresFaker = new AddressFaker();
    public CustomerFaker() {
        int id = 1;
        UseSeed(1969)
          .RuleFor(c => c.Id, _ => id++)
          .RuleFor(c => c.CompanyName, f => f.Company.CompanyName())
          .RuleFor(c => c.ContactName, f => f.Name.FullName())
          .RuleFor(c => c.Phone, f => f.Phone.PhoneNumberFormat())
          .RuleFor(c => c.Address, f => addresFaker.Generate(1).First());
    }
}