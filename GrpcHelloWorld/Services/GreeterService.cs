using Grpc.Core;
using GrpcHelloWorld;

public class GreeterService : Greeter.GreeterBase
{
    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        Console.WriteLine($"Received message: {request.Message}");
        return Task.FromResult(new HelloReply
        {
            Response = $"Received message: {request.Message}"
        });
    }
}
