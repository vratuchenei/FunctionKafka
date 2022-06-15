# FunctionKafka
Azure Function to trigger Kafka consumer.

## Commands to start Kafka localhost on Windows:

### Start zookeeper:

> .\zookeeper-server-start.bat ..\..\config\zookeeper.properties


### Start kafka server:

> .\kafka-server-start.bat ..\..\config\server.properties


### Create nova mensagem:

> .\kafka-console-producer.bat --broker-list localhost:9092 --topic test-topic

> { "id": 1, "first_name": "John", "last_name": "Lindt", "email": "jlindt@gmail.com", "gender": "Male", "product": 1234 }
> { "id": 2, "first_name": "John", "last_name": "Lindt", "email": "jlindt@gmail.com", "gender": "Male", "product": 5678 }


### Start kafka connect distributed:

> .\connect-distributed.bat ..\..\config\connect-distributed.properties

GET http://localhost:8083/connectors


### Powershell commands to list and stop services on windows:

> netstat -abnovp tcp | Select-String <<string-pattern>>

> kill <<PID>>
