# gRPC Hello World Project
This project demonstrates a simple gRPC service using C# that sends a "Hello, World!" message. It consists of two parts: a server (gRPC server) and a client (gRPC client).
---
## Prerequisites
- Visual Studio 2022
- .NET 6.0 SDK or higher
- gRPC NuGet packages for C#
--- 
# Project Structure
## GrpcHelloWorld (Server)
1. This project hosts the gRPC service that receives requests and returns responses.
2. The service is defined using a .proto file which specifies the service and message formats.
3. The server listens on a specified port (e.g., localhost:5295 for HTTP or localhost:7002 for HTTPS).

   
## GrpcClient (Client)
This project is a console application that connects to the gRPC server and sends a request to the SayHello method.

# Setup Instructions
## Setting up the gRPC Server (GrpcHelloWorld)
1. Open the solution in Visual Studio 2022.
2. Navigate to the GrpcHelloWorld project.
3. Ensure the gRPC service is correctly set up by verifying the .proto file (located in the project) and the GreeterService implementation.
4. The GreeterService class implements the SayHello method, which returns a "Hello, World!" message when requested.
5. Run the server by pressing Ctrl + F5 or using the Visual Studio toolbar to start the application.
6. The server will start listening on http://localhost:5295 or https://localhost:7002 (depending on your configuration).
   ---
## Setting up the gRPC Client (GrpcClient)
1. Open the solution in Visual Studio 2022.
2. Navigate to the GrpcClient project.
3. Add a reference to the GrpcHelloWorld project.
4. Ensure the GreeterClient is correctly set up to call the SayHello method from the gRPC server.
5. Run the client application to send a request to the server and display the response message ("Hello, World!").

   --- 

## Dependencies
- Grpc.Net.Client: Package to enable gRPC client functionality.
- Grpc.Tools: Package to automatically generate C# files from the .proto file.
- Google.Protobuf: Package for working with protocol buffers (used by gRPC).

### Error Handling
If you encounter errors such as connection issues or missing methods, ensure the server is running and the client is configured with the correct server URL and .proto file.

---
## Additional Information
Screenshoots of the consoles of the projects
- Server
  ![image](https://github.com/user-attachments/assets/d28f446b-7bc3-49a6-a834-5a13728f2349)

- Client
  ![image](https://github.com/user-attachments/assets/c372ceda-1687-4d8d-9327-0e769817f51b)
