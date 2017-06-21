using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using Xamarin.Forms;
using Android.Content;
using Android.Telephony;
using System.Linq;
using Uri = Android.Net.Uri;
using FinalProjectWeek3.Droid;

[assembly: Xamarin.Forms.Dependency (typeof(MainActivity))]
namespace FinalProjectWeek3.Droid
{
    [Activity(Label = "Agenda", Icon = "@drawable/ic_launcher", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity, ICallContact
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
           
    }
        public Task<bool> DialAsync(string number)
        {
            var context = Forms.Context;
            if (context != null)
            {
                var intent = new Intent(Intent.ActionCall);
                intent.SetData(Uri.Parse("tel:" + number));
                if (IsIntentAvailable(context, intent))
                {
                    context.StartActivity(intent);
                    return Task.FromResult(true);
                }
            }

            return Task.FromResult(false);
        }

        /// <summary>
        /// Checks if an intent can be handled.
        /// </summary>
        public static bool IsIntentAvailable(Context context, Intent intent)
        {
            var packageManager = context.PackageManager;
            var list = packageManager.QueryIntentServices(intent, 0)
            .Union(packageManager.QueryIntentActivities(intent, 0));
            if (list.Any())
                return true;
            TelephonyManager mgr = TelephonyManager.FromContext(context);
            return mgr.PhoneType != PhoneType.None;
        }

        public void dialContact(string number)
        {
            var response = DialAsync(number);
        }
    }

        
    }

