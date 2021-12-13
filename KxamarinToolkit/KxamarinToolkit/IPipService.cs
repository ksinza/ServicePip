using System;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;

namespace KxamarinToolkit
{
    public interface IPipService
    {
        Task<bool> ActivePip(MediaElement e);
    }
}
