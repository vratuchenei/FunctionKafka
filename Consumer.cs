using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Kafka;
using Microsoft.Extensions.Logging;

namespace FunctionKafkaConsumer
{
    public class Consumer
    { 
        // KafkaTrigger sample 
        // Consume the message from "topic" on the LocalBroker.
        // Add `BrokerList` and `KafkaPassword` to the local.settings.json
        // For EventHubs
        // "BrokerList": "{EVENT_HUBS_NAMESPACE}.servicebus.windows.net:9093"
        // "KafkaPassword":"{EVENT_HUBS_CONNECTION_STRING}
        [FunctionName("Consumer")]
        public void Run(
            [KafkaTrigger("localhost:9092",
                          "test-topic",
                          //Username = "teste",   //"$ConnectionString",
                          //Password = "",        //"%KafkaPassword%",
                          Protocol = BrokerProtocol.Plaintext,
                          AuthenticationMode = BrokerAuthenticationMode.NotSet,
                          ConsumerGroup = "test")] KafkaEventData<string>[] events, ILogger log)
        {
            foreach (KafkaEventData<string> eventData in events)
            {
                log.LogInformation($"C# Kafka trigger function processed a message: {eventData.Value}");
            }
        }
    }
}
