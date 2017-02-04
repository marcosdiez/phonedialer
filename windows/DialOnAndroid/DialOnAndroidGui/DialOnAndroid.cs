using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DialOnAndroidGui
{
    class DialOnAndroid
    {
        static String FIREBASE_SERVER_KEY = "AIzaSyCjhUu4DpLdHxKjbldyKp5VvRz5ppXb5f0";

        async public static Task<String> SendNotificationFromFirebaseCloud(String deviceId, String number)
        {
            if (deviceId == null || deviceId == "")
            {
                return "Error: deviceId is null";
            }

            if (number == null || number == "")
            {
                return "Error: number is null";
            }
            var result = "-1";
            var webAddr = "https://fcm.googleapis.com/fcm/send";

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Headers.Add("Authorization:key=" + FIREBASE_SERVER_KEY);
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(await httpWebRequest.GetRequestStreamAsync()))
            {
                var json = getJsonData(deviceId, number);

                await streamWriter.WriteAsync(json);
                await streamWriter.FlushAsync();
            }

            result = await getResult(httpWebRequest);

            return result;
        }

        private static string getJsonData(string deviceId, string number)
        {
            /*
              the fact that I sent part of the GoogleFireBaseId token looks ridiculous but it is not.
              I want to open source this app and include the google cloud certificates as well
              That means anybody would be able to send a broadcast message to all devices and use it
              as a war dialer.

              So this forces my app only to receive direct messages and not broadcasts :)
            */

            var data = new
            {
                to = deviceId,
                data = new
                {
                    auth = deviceId.Substring(0, 16),  
                    dial = number  // "+5511971407657"
                }
            };

            var serializer = new JavaScriptSerializer();
            var json = serializer.Serialize(data);
            return json;
        }

        private async static Task<string> getResult(HttpWebRequest httpWebRequest)
        {
            var bufferSize = 4096;
            var buffer = new byte[bufferSize];
            var read = 0;
            var httpResponse = await httpWebRequest.GetResponseAsync();
            var stream = httpResponse.GetResponseStream();
            using (var ms = new MemoryStream())
            {
                while ((read = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                ms.Position = 0;
                return new StreamReader(ms).ReadToEnd().Trim();
            }
        }
    }
}
