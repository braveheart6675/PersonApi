using Grpc.Net.Client;
using PersonApi.Protos; // Namespace from your .proto file
using System;
using System.Threading.Tasks;


class Program
{
    static async Task Main(string[] args)
    {
        // Ensure the server is running and using HTTPS
        var grpcChannel = GrpcChannel.ForAddress("https://localhost:5113"); // Use correct port

        var client = new PersonService.PersonServiceClient(grpcChannel);

        // Create a new person
        var createResponse = await client.CreatePersonAsync(new Person
        {
            Name = "Arman",
            FamilyName = "Sadeghian",
            SocialNumber = "0069744939",
            BirthDate = "1981-06-06"
        });

        Console.WriteLine($"Created Person with ID: {createResponse.Id}");

        // Retrieve the person
        var person = await client.GetPersonAsync(new PersonIdRequest { Id = createResponse.Id });

        Console.WriteLine($"Retrieved: {person.Name} {person.FamilyName}");
    }
}
