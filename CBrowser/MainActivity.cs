using Android.App;
using Android.Widget;
using Android.OS;

namespace CBrowser
{
    [Activity(Label = "CBrowser", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Albergue a = new Albergue("langdraget","Nikolai",5,31431499,true,true,true,false);

        }
    }
}

