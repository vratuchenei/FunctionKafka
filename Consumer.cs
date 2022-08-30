using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Kafka;
using Microsoft.Extensions.Logging;
using System;

namespace FunctionKafkaConsumer
{
    public class Consumer
    {
        const string BROKER = "localhost:9092";   //"10.128.145.106:9092";
        const string TOPIC = "via-mais-figital";
        const string CONSUMER_GROUP = "via-martech-viamais-dev";

        [FunctionName("Consumer")]
        public void Run([KafkaTrigger(BROKER, TOPIC, ConsumerGroup = CONSUMER_GROUP)] KafkaEventData<string>[] events, ILogger log)
        {
            var teste = Environment.GetEnvironmentVariable("IsEncrypted");

            foreach (KafkaEventData<string> eventData in events)
            {
                log.LogInformation($"C# Kafka trigger function processed a message: {eventData.Value}");
            }
            
        }
    }
}
