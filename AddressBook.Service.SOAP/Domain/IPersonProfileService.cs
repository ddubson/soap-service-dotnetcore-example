using System.Collections.Generic;
using System.ServiceModel;

namespace AddressBook.Service.SOAP.Domain
{
    [ServiceContract]
    public interface IPersonProfileService
    {
        [OperationContract]
        public IEnumerable<PersonProfile> GetAllProfiles();

        [OperationContract]
        public PersonProfile GetProfileById(int id);
    }
}