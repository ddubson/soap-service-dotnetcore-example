using System;
using System.Linq;
using System.ServiceModel;
using AddressBook.Service.SOAP.Domain;
using Xunit;

namespace AddressBook.Service.SOAP.IntegrationTests
{
    public class SoapClientTests: SoapClientBase
    {
        /// NOTE:
        ///
        /// SOAP Service classes are used from the SOAP service project here
        /// In real life situations, you will most likely not have access to the SOAP service code
        /// Check out how to generate client classes from the WSDL using the `svcutil` utility to completely
        /// decouple from the SOAP service
        [Fact]
        public void GetAllProfiles_ReturnsAllProfiles_ViaSoapService()
        {
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(new Uri(WSDLUrl));
            ChannelFactory<IPersonProfileService> channelFactory = new ChannelFactory<IPersonProfileService>(binding, endpoint);
            IPersonProfileService serviceClient = channelFactory.CreateChannel();
            var allProfiles = serviceClient.GetAllProfiles();
            Assert.NotNull(allProfiles);
            Assert.Equal(3, allProfiles.Count());
        }
    }
}