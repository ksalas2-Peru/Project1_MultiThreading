Uses named pipes to allow communication between two separate processes.

One process acts as the server and writes data to a pipe.

Another process acts as the client and reads the data.

Demonstrates how processes can exchange messages efficiently and handle potential connection failures.


How to Run:

1. Compile and Run Multi-Threading Phases
     dotnet run --project ProjectA_MultiThreading

2. Run IPC Server
     dotnet run --project ProjectB_IPC -- server

3. Run IPC Client
     dotnet run --project ProjectB_IPC -- client

Ensure both the server and client are executed in separate terminals for IPC communication.
