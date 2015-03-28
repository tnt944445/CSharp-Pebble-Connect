# CSharp-Pebble-Connect
Allows you to use any .NET language to send a message to your pebble

#Using it
C#
```C#
using System;
using Pebble_Connect;

namespace Pebble_Connect_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            PebbleConnect.postMessage("userId", "userToken", "messageBody", "messageTitle");
        }
    }
}
```
