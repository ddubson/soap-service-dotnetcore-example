run-soap-service:
	@echo "✨ Launching SOAP service on port 9310"
	dotnet run --project AddressBook.Service.SOAP/

run-soap-client-tests:
	dotnet test AddressBook.Service.SOAP.IntegrationTests

ship-it: run-soap-client-tests
	@echo "Ship ship ship!"