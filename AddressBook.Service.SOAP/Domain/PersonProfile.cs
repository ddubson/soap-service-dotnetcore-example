using System.Runtime.Serialization;

namespace AddressBook.Service.SOAP.Domain
{
    [DataContract]
    public class PersonProfile
    {
        [DataMember] public long Id { get; set; }
        [DataMember] public string FirstName { get; set; }
        [DataMember] public string LastName { get; set; }
    }
}