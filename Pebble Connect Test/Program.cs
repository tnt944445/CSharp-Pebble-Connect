using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pebble_Connect;

namespace Pebble_Connect_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var response = PebbleConnect.postMessage("userId", "userToken", "This is a test", "Poop Train!");

            Console.Write(response);
        }
    }
}
