namespace CustomerDatabase.Server.Models
{
    public class CustomerInfo
    {
        //CustomerID
        //Customer FirstName
        //Customer LastName
        //Customer PhoneNumber
        //Customer Email
        //Customer StreetAddress

        //??Zip Code Table for state and city IT350notes??
        public int CustomerID { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerStreetAddress { get; set; }

    }
}
