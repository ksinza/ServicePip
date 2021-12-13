using System;
using System.Runtime.Remoting.Contexts;
using Android.App;
using KxamarinToolkit.Droid;
using Xamarin.Forms;
using Android.Util;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;

[assembly: Dependency(typeof(PipService))]
namespace KxamarinToolkit.Droid
{
    public class PipService : IPipService
    {
        public static TaskCompletionSource<bool> task;
       // MainActivity activity;
        public PipService()
        {
        }
        PictureInPictureParams.Builder pictureInPictureParamsBuilder = new PictureInPictureParams.Builder();
        Context context = new Context();
      
        

        Task<bool> IPipService.ActivePip(MediaElement e)
        {
            var aspectRatio = new Rational((int)e.WidthRequest, (int)e.HeightRequest);
            pictureInPictureParamsBuilder.SetAspectRatio(aspectRatio).Build();


            var activity = (Activity)Forms.Context;

            activity.EnterPictureInPictureMode(pictureInPictureParamsBuilder.Build());

            task = new TaskCompletionSource<bool>();
            return task.Task;

        }
    }
}
