# Chat App with C# Windows Forms and WebSocket

![Chat App Screenshot](https://github.com/Mido191020/Chat_Program/raw/master/Screenshot%202023-09-18%20152638.png)

A simple chat application built using C# Windows Forms and WebSocket communication. This application allows users to exchange messages over a local network using UDP and stores chat logs in a SQL Server database.

## Table of Contents

- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [WebSocket Communication](#websocket-communication)
- [Database Configuration](#database-configuration)
- [Contributing](#contributing)

## Features

- Real-time chat between users on the same local network.
- Database storage of chat messages with sender and receiver IP addresses.
- User-friendly Windows Forms interface.

## Getting Started

### Prerequisites

Before running the application, make sure you have the following prerequisites:

- Visual Studio with C# support (for development).
- SQL Server (for database storage).

### Installation

1. **Clone this repository** to your local machine:

   ```shell
   git clone https://github.com/yourusername/your-repo-name.git
   ```

2. **Open the project in Visual Studio.**

3. **Modify the `connectionString` variable** in `Form1.cs` to point to your SQL Server instance:

   ```csharp
   private string connectionString = "Server=YOUR_SERVER;Database=client logs;Integrated Security=True;";
   ```

4. **Build and run the application.**

## Usage

1. Start the application on **two different computers within the same local network**.
2. Enter the **local IP address** of each computer and **port numbers** in the appropriate fields.
3. Click the **"Start" button** to connect the two computers.
4. Send messages in the chat box, and they will be displayed in real-time on both computers.
5. Chat messages are stored in the SQL Server database.

## WebSocket Communication

This chat application leverages **WebSocket communication** to enable real-time messaging between users on the same local network. WebSocket is a protocol that provides full-duplex communication channels over a single TCP connection. WebSocket communication enables low-latency, bidirectional messaging, making it suitable for real-time chat applications.

## Database Configuration

You can find the database configuration in the `CheckDatabaseConnection` and `StoreMessageData` methods in `Form1.cs`. Ensure that your SQL Server is configured correctly for this application to work.

## Contributing

If you'd like to contribute to this project, please follow these steps:

1. **Fork the repository.**
2. Create a new branch for your feature or bug fix: `git checkout -b feature-name`.
3. Make your changes and commit them: `git commit -m 'Description of your changes'`.
4. Push to the branch: `git push origin feature-name`.
5. Create a **pull request on GitHub**.
