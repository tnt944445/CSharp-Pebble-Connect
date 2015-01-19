using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Pebble_Connect
{
    public class PebbleConnect
    {
        /// <summary>
        /// This method is used to send a message to your pebble via Pebble Connect(r) with default server
        /// </summary>
        /// <param name="userID">The id that you set in the app</param>
        /// <param name="userToken">The token that you set in the app</param>
        /// <param name="messageBody">The body of the message that you want to send to your pebble</param>
        /// <param name="messageTitle">The title of the message that you want to send to your pebble</param>
        public static object postMessage(string userID, string userToken, string messageBody, string messageTitle)
        {
            var restClient = new RestClient("https://ofkorth.net/pebble/send");
            var request = new RestRequest(Method.POST);

            request.AddParameter("type", "notification");
            request.AddParameter("userId", userID);
            request.AddParameter("userToken", userToken);
            request.AddParameter("title", messageTitle);
            request.AddParameter("body", messageBody);

            var response = restClient.Execute(request);

            return response;
        }

        /// <summary>
        /// This method is used to send a message to your pebble via Pebble Connect(r) with your own server
        /// </summary>
        /// <param name="userID">The id that you set in the app</param>
        /// <param name="userToken">The token that you set in the app</param>
        /// <param name="messageBody">The body of the message that you want to send to your pebble</param>
        /// <param name="messageTitle">The title of the message that you want to send to your pebble</param>>
        public static object postMessage(string userID, string userToken, string messageBody, string messageTitle, string serverURL)
        {
            var restClient = new RestClient(serverURL);
            var request = new RestRequest(Method.POST);

            request.AddParameter("type", "notification");
            request.AddParameter("userId", userID);
            request.AddParameter("userToken", userToken);
            request.AddParameter("title", messageTitle);
            request.AddParameter("body", messageBody);

            var response = restClient.Execute(request);

            return response;
        }
    }
}
