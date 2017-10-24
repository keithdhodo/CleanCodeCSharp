namespace Chapter06.Models
{
    public class Address
    {
        public string Street { get; private set; }
        public string StreetExtra { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }

        public Address(string street, string streetExtra, string city, string state, string zipcode)
        {
            Street = street;
            StreetExtra = streetExtra;
            City = city;
            State = state;
            ZipCode = zipcode;
        }
    }
}
