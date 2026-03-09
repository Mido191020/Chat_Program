# P2P UDP Chat Program

![Chat App Screenshot](https://github.com/Mido191020/Chat_Program/raw/master/Screenshot%202023-09-18%20152638.png)

A lightweight, peer-to-peer chat application built in C# and Windows Forms. This application enables two users on the same network (or across the internet with port forwarding) to communicate seamlessly using the UDP protocol. It also logs all messages to a local SQL Server database for historical persistence.

## Features

- **Peer-to-Peer Communication**: Connects directly to a friend using IP Addresses and Ports.
- **Asynchronous Networking**: Implements non-blocking `BeginReceiveFrom` socket logic to keep the UI responsive.
- **Persistent Chat Logs**: Automatically saves sent and received messages to a Microsoft SQL database.
- **Local Network Auto-Discovery**: Automatically grabs the executing machine's IPv4 address.

## Architecture

This system utilizes a P2P architectural model. There is no central server. Both instances of the application act identically: binding to a local port to listen for incoming UDP datagrams while simultaneously opening a route to a remote host's IP and port to send outgoing messages.

## Technologies Used

- **Language**: C#
- **Framework**: .NET Framework (Windows Forms)
- **Networking**: `System.Net.Sockets` (UDP)
- **Database**: Microsoft SQL Server (`System.Data.SqlClient`)

## Installation and Setup

1. **Database Setup**:
   - Ensure you have a local instance of SQL Server running.
   - Create a database named `client logs`.
   - Create a table named `clientlogs` with columns: `SenderIP`, `ReceiverIP`, `MessageText`, `MessageDateTime`, `IPAddress`, `LogDateTime`.
   - *Note*: Ensure your connection string in `Form1.cs` matches your SQL local instance name (e.g., `Server=YOUR-PC-NAME;Database=client logs;Integrated Security=True;`).
2. **Build**: Open `Chat Program.sln` in Visual Studio and hit Build, or compile via MSBuild.

## Usage

1. Run the application.
2. The **Local IP** will automatically populate. Enter a designated **Local Port** (e.g., `8080`).
3. Enter your friend's IP in **Friend IP** and their opening port in **Friend Port**.
4. Click **Start**. The app will bind the ports and load previous database chat history.
5. Type your message and click **Send**.