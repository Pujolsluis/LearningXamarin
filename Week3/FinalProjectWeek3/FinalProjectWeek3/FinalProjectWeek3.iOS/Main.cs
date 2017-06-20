using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using System.Threading.Tasks;

[assembly:Xamarin.Forms.Dependency(typeof(AppDomain))]
namespace FinalProjectWeek3.iOS
{
    public class Application : ICallContact
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }

        public Task<bool> DialAsync(string number)
        {
            return Task.FromResult(
            UIApplication.SharedApplication.OpenUrl(
            new NSUrl("tel:" + number))
            );
        }

        public void dialContact(string number)
        {
            var response = DialAsync(number);
        }
    }
}
