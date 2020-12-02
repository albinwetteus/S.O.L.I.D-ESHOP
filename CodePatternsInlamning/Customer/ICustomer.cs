using System.Collections.Generic;

namespace CodePatternsInlamning
{
    //Contains model for customer

    public interface ICustomer
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string StreetAddress { get; set; }
        string PhoneNumber { get; set; }
    }
}