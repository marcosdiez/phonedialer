using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;


namespace DialOnAndroid
{
    class Program
    {
        static String FIREBASE_SERVER_KEY = "AIzaSyCjhUu4DpLdHxKjbldyKp5VvRz5ppXb5f0";

        static void Main(string[] args)
        {
            if(args.Length < 1)
            {
                Console.WriteLine(String.Format("Usage: {0} PHONE_NUMBER_TO_BE_DIALED", System.AppDomain.CurrentDomain.FriendlyName));
                Environment.ExitCode = 2;
                return;
            }

            var number = args[0];

            Console.WriteLine(String.Format("Sending [{0}] to device.", number));
            Console.WriteLine(SendNotificationFromFirebaseCloud(number));
        }
        

        public static String SendNotificationFromFirebaseCloud(String number)
        {
            var result = "-1";
            var webAddr = "https://fcm.googleapis.com/fcm/send";

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(webAddr);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Headers.Add("Authorization:key=" + FIREBASE_SERVER_KEY);
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                //var tablet = "fu9AvQQSrQU:APA91bGNkpFsME1AMgy9i8PnRjyXu7ww72yrQdV2dVAC6WvHVzi9Q7d8qGE5FuvFksj3mWLo-Is5pHKr6crX4iosWZLQKCwSXhPN7IYPnCBmtBMJPzPA63O_a8H8uOv2SkNFY-XXr80u";
                //var phone = "ekhwv69hZqI:APA91bF6yoNBUOTiPyAm_WJQ729SW8Q1htoLWUiFFlSGz-rlQetv0Wd9dN-xGV81E6znxlDLeD24wacv8EWATsdEcIocxnDVfwEwRAuyiqmvjT3sQLUslqtVchonJrbXr1qgGxfznNYP";
                //var deviceId = phone;

                var deviceId = "f4fCbiXLya4:APA91bGkGYZ9_H1V-glIZZxVcOJoQNeB6FQkgVOuAgVQuGfNgdQVJOvyo2TNRqJoI1_qC0h_M_ApfKc1PWak2LlPfWRk90FTwFQQsdM-QI16mDmPOrFeddJ0LC46phan2YgK2EGRfuSk";
                var rander = new Random().NextDouble().ToString();
                var data = new
                {
                    to = deviceId,
                    data = new
                    {
                        dial = number  // "+5511971407657_" + rander
                    }
                };

                var serializer = new JavaScriptSerializer();
                var json = serializer.Serialize(data);


                streamWriter.Write(json);
                streamWriter.Flush();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return result;
        }

    }

}
