using Grpc.Net.Client;
using GrpcHelloWorld;

class Program
{
    static async Task Main(string[] args)
    {
        // Establecer el canal
        var channel = GrpcChannel.ForAddress("http://localhost:5295");


        // Crear el cliente
        var client = new Greeter.GreeterClient(channel);

        // Enviar una solicitud al servidor
        var reply = await client.SayHelloAsync(new HelloRequest { Message = "Hello, gRPC!" });

        Console.WriteLine("Server response: " + reply.Response);
    }
}
