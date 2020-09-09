using System.Collections.Generic;
using AddressBook.Service.SOAP.Domain;
using AddressBook.Service.SOAP.Repositories;
using Microsoft.Extensions.Logging;

namespace AddressBook.Service.SOAP
{
    public class PersonProfileService: IPersonProfileService
    {
        private readonly PersonProfileRepository _repository;
        private readonly ILogger<PersonProfileRepository> _logger;

        public PersonProfileService(PersonProfileRepository repository, ILogger<PersonProfileRepository> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        
        public IEnumerable<PersonProfile> GetAllProfiles()
        {
            _logger.LogInformation("Fetched all profiles.");
            return _repository.FetchAll();
        }

        public PersonProfile GetProfileById(int id)
        {
            _logger.LogInformation("Fetched all profiles.");
            return _repository.FindById(id);
        }
    }
}