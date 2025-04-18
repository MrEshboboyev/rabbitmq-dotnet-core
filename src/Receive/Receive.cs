using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

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

Console.WriteLine(" [x] Waiting for messages");

var consumer = new AsyncEventingBasicConsumer(channel);
consumer.ReceivedAsync += (model, ea) =>
{
    var body = ea.Body.ToArray();
    var message = Encoding.UTF8.GetString(body);
    Console.WriteLine($" [x] Received message {message}");
    return Task.CompletedTask;
};

await channel.BasicConsumeAsync("hello", true, consumer);

Console.WriteLine("Press [enter] to exit...");
Console.ReadLine();
