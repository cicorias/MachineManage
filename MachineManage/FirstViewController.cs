using System;
using System.Net.Http;

using System.Threading.Tasks;

using UIKit;

namespace MachineManage
{
  public partial class FirstViewController : UIViewController
  {
    public FirstViewController (IntPtr handle) : base (handle)
    {
    }

    public override void ViewDidLoad ()
    {
      base.ViewDidLoad ();
      // Perform any additional setup after loading the view, typically from a nib.
    }

    public override void DidReceiveMemoryWarning ()
    {
      base.DidReceiveMemoryWarning ();
      // Release any cached data, images, etc that aren't in use.
    }

    async partial void UIButton5_TouchUpInside (UIButton sender)
    {
      //stop buttion
      await RunCall("stop");

    }

    async partial void UIButton14_TouchUpInside (UIButton sender)
    {
      await RunCall("start");
    }


    async Task<int> RunCall(string action){
      
      string url = null;
      if (action.Equals("start", StringComparison.InvariantCultureIgnoreCase))
        url = "https://s1events.azure-automation.net/webhooks?token=..";
      if (action.Equals("stop", StringComparison.InvariantCultureIgnoreCase))
        url = "https://s1events.azure-automation.net/webhooks?token=..";
      
      var client = new HttpClient();
      await client.PostAsync(url, new StringContent(""));
      return 0;

    }


  }
}

