using System.Collections.Generic;

namespace CodePatternsInlamning
{
    //Contains model for customer
    public class Customer : ICustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string StreetAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}