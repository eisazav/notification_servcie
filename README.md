# NotificationService


Notification Service is a robust, event-driven application designed to send notifications via email using Twilio. The application follows Hexagonal Architecture and leverages RabbitMQ for resilient message processing.

## Overview

The Notification Service is designed to handle and send email notifications triggered by various events. By using Twilio for email delivery and RabbitMQ for message queuing, the service ensures reliable and scalable notification delivery.

## Features

Event-Driven Architecture: Reacts to events and processes notifications asynchronously.
Hexagonal Architecture: Maintains separation of concerns and promotes testability and maintainability.
RabbitMQ Integration: Utilizes RabbitMQ for message queuing, ensuring resilience and reliability.
Twilio Email Integration: Sends emails using Twilio's email service.

## Architecture

### Event-Driven

The application is built around an event-driven architecture, where events trigger the creation and sending of notifications. This decouples the notification logic from the rest of the system, allowing for greater flexibility and scalability.

### Hexagonal Architecture

Hexagonal Architecture, also known as Ports and Adapters, is used to keep the core logic of the application independent from external services and technologies. This architecture enhances testability and allows for easier maintenance and evolution of the application.

### RabbitMQ

RabbitMQ is used to manage message queues, providing a reliable and fault-tolerant way to handle notifications. It ensures that messages are processed asynchronously and can be retried in case of failures.

## License
Notification Service is licensed under the [Apache 2.0 license](./LICENSE).
