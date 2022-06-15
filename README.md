# FunctionKafka
Azure Function to trigger Kafka consumer.

## Commands to start Kafka localhost on Windows:

### Start zookeeper:

```bash
.\zookeeper-server-start.bat ..\..\config\zookeeper.properties
```


### Start kafka server:

```bash
.\kafka-server-start.bat ..\..\config\server.properties
```


### Create message:

```bash
.\kafka-console-producer.bat --broker-list localhost:9092 --topic test-topic
> { "id": 1, "first_name": "John", "last_name": "Lindt", "email": "jlindt@gmail.com", "gender": "Male", "product": 1234 }
> { "id": 2, "first_name": "John", "last_name": "Lindt", "email": "jlindt@gmail.com", "gender": "Male", "product": 5678 }
```


### Start kafka connect distributed:

```bash
.\connect-distributed.bat ..\..\config\connect-distributed.properties
```


### List kafka connectors:

GET http://localhost:8083/connectors


### Powershell commands to list and stop services on windows:


```bash
netstat -abnovp tcp | Select-String <string-pattern>
kill <PID>
```


## License
[MIT](https://choosealicense.com/licenses/mit/)
