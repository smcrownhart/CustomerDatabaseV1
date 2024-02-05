namespace CustomerDatabase.Server.Models
{
    public class AttemptedContacts
    {
        //got a hold of someone?True or False
        //put notes in a string.
        //Link EmployeeId as person who called and CustomerId as person attempted to call
        public bool Contacted { get; set; }
        public string Notes { get; set; }
    }
}
