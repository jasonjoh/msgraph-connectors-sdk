## About
Microsoft Graph connectors SDK helps you build custom connectors for your line of business data sources quickly and efficiently in any of [11 available languages](https://grpc.io/docs/languages/ "11 available languages"). You can leverage the capabilities of our robust Graph connector platform for indexing any of your cloud or on-prem data sources. The SDK also gives you the capability to manage your custom as well as Microsoft's out of the box connectors all in one place through the Microsoft Admin Center.

_Note: Microsoft Graph connectors SDK is available in **preview**_

## Graph Connector Agent (Platform)
This lightweight app takes care of orchestration capabilities and coordinates between Microsoft Admin Center and customer's connector code. More on the software: [On-Premises Agent | Microsoft Docs](https://docs.microsoft.com/en-us/MicrosoftSearch/graph-connector-agent "On-Premises Agent | Microsoft Docs"). The capabilities of the platform are captured below:
![4e6e95fd-2980-443c-9e6b-5f63b2539360](https://user-images.githubusercontent.com/53271958/154615969-65ebf18e-c48c-450a-b5e8-82a5009034e0.png)

![cb4a492d-2e08-47bb-90f8-0009f7f0fa2d](https://user-images.githubusercontent.com/53271958/154615967-0843d987-60c2-4fc2-b6d0-ada856c09777.png)

![e3c44724-8d2d-47ad-931d-43ae2c65c36a](https://user-images.githubusercontent.com/53271958/154615963-c623ecdb-9501-45c0-9e13-294df273f65e.png)


## Get Started
1. Install GCP and follow the instructions to register the agent [On-Premises Agent | Microsoft Docs](https://docs.microsoft.com/en-us/MicrosoftSearch/graph-connector-agent "On-Premises Agent | Microsoft Docs").
2. Download the proto files with [gRPC contracts](https://github.com/microsoftgraph/msgraph-connectors-sdk/tree/main/Contracts "gRPC contracts").
3. Protobuf compiler downloaded and extracted from [here](https://github.com/protocolbuffers/protobuf/releases/download/v3.19.4/protoc-3.19.4-win64.zip "here") (Not needed if using Visual Studio).
	- Environment path updated with bin folder in extracted root.
	- Compile contracts to create server-side stubs in the language of your choice. More info [here](https://grpc.io/docs/languages/ "11 available languages").
4. Create a project in your IDE and place all the proto files in a folder named "Contracts". Sample project structure here:

	![887ad2fd-63a3-41b3-a156-0ce3a15b0d86](https://user-images.githubusercontent.com/53271958/154617030-8263796a-a9b9-4417-8d3e-d7a189e8b1e7.png)
5. Implement methods in the stubs generated by the compiler.
6. Create a server, run the application and generate the executable/output binaries.
7. Edit the CustomConnectorPortMap JSON file in the GCA installation folder (Program files > Graph connector agent) with connector id (same as provider id) and TCP port information (port on which you are running the server).
	- You may need to open notepad/VS in admin mode to edit the JSON.
8. Test the connector code via TestApp (See below Testing section).
9. Create a custom connector connection on Microsoft Admin Center.

## Testing
1. Fill relevant details in the TestApp config files (AgentConfig.json and ConnectionInfo.json) inside the config folder(Program files> Graph connector agent > TestApp> Config)
	- You may need to open notepad/VS in admin mode to edit the JSON files.
	- Sample ConnectionInfo.json
		- Replace the providerId with connector id.
		- Change the connection ID for each test app run.
	- Sample AgentConfig.json
		- Replace the values of tenantId, clientId and secret with the tenant you are using.
		- Do not change the mockIngestion flag.
2. Test out connector code flows using TestApp present in the GCA installation folder (Program files> Graph connector agent > TestApp> GraphConnectorAgentTest.exe)
	- TestApp is only for local testing.
	- Only one test case can be run at a time. You will have to exit and relaunch the app for testing another scenario.


