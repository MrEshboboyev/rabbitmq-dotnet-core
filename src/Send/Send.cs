using System.Text;
using RabbitMQ.Client;

Console.WriteLine("Hello, World!");

var factory = new ConnectionFactory()
{
    Uri = new Uri("amqps://b-429a72df-4119-49ac-8b42-863820610586.mq.us-east-1.amazonaws.com"),
    Port = 5671,
    UserName = "admin",
    Password = "admin-password" // DO NOT DO THIS IN REAL WORLD APPLICATIONS
};

await using var connection = await factory.CreateConnectionAsync();
await using var channel = await connection.CreateChannelAsync();

await channel.QueueDeclareAsync("hello", false, false, false, null);

string? message = null;

do
{
    Console.WriteLine("Please enter your messageArg:");
    message = Console.ReadLine();
    if (!string.IsNullOrEmpty(message))
        SendMessage(channel, message);
} while (!string.IsNullOrEmpty(message));

void SendMessage(IChannel channelArg, string messageArg)
{
    var body = Encoding.UTF8.GetBytes(messageArg);
    channelArg.BasicPublishAsync(string.Empty, "hello", false, body);
    Console.WriteLine($"[x] Send {messageArg}");
}