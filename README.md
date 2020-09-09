# SOAP Service client example

This is an example project of how a .NET Core 3.1 SOAP service can be created, launched, and 
then consumed by a .NET Core 3.1 SOAP client. Fun!

The primary SOAP library used is [SoapCore](https://github.com/DigDes/SoapCore)

## Operator Manual

Operate via make:

- `run-soap-service` - stand up SOAP service on port 9310
- `run-soap-client-tests` - run example SOAP client tests (uses test web host SOAP service)
- `ship-it` - run the tests

## SOAP Service

The project `AddressBook.Service.SOAP` hosts a basic SOAP service, and the WSDL definition is hosted 
locally at:

```bash
https://localhost:9310/PersonProfileService.asmx
```

Check out [sample SOAP calls here](./AddressBookSOAPRequests.http)

## SOAP Client

The SOAP client example is encapsulated in the `AddressBook.Service.SOAP.IntegrationTests` as example test code to connect to a
SOAP service. It utilizes the SOAP service from the previous section to stand up a test Kestrel server.

```bash
make run-soap-client-tests
```

## TODO or what's not covered (yet)

- Set up and launch an example SOAP service (maybe via Docker)
