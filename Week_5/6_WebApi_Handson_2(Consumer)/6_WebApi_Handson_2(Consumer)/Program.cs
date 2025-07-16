namespace _6_WebApi_Handson_2_Consumer_
{
    using Confluent.Kafka;

    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "chat-consumer-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();

            consumer.Subscribe("chat-topic");

            Console.WriteLine("Waiting for messages...");

            try
            {
                while (true)
                {
                    var cr = consumer.Consume();
                    Console.WriteLine($"Received: {cr.Message.Value}");
                }
            }
            catch (ConsumeException ex)
            {
                Console.WriteLine($"Error: {ex.Error.Reason}");
            }
        }
    }

}
