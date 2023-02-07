namespace FakerDataSample.Models; 
public class Address {
    public int Id { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? StateProvince { get; set; }
    public string? PostalCode { get; set; }

    public override string ToString() {
        return $"{Id} {Address1} {Address2} {City} {StateProvince} {PostalCode}";
    }
}