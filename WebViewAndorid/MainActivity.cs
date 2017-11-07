using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace WebViewAndorid
{
    [Activity(Label = "WebViewAndorid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            var webView = FindViewById<WebView>(Resource.Id.MyWebView);
            webView.SetWebViewClient(new WebViewClient());
            webView.Settings.JavaScriptEnabled = true;

            webView.LoadUrl("file:///android_asset/a.html");
        }
    }
}

