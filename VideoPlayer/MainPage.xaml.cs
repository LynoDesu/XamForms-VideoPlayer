using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xam.Forms.VideoPlayer;
using Xamarin.Forms;
using static Xam.Forms.VideoPlayer.VideoPlayer;

namespace VideoPlayer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private VideoSource _videoSource = VideoSource.FromUri("https://sample-videos.com/video123/mp4/720/big_buck_bunny_720p_1mb.mp4");

        protected override void OnAppearing()
        {
            base.OnAppearing();
            videoPlayer.Source = _videoSource;
            if (Device.RuntimePlatform == Device.Android)
            {
                //NavigationPage.SetHasNavigationBar(this, false);
                DependencyService.Get<IStatusBar>().HideStatusBar();
            }
        }

        private void VideoPlayer_PlayCompletion(object sender, EventArgs e)
        {

        }

        private void VideoPlayer_PlayError(object sender, PlayErrorEventArgs e)
        {

        }

        protected override void OnDisappearing()
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                //NavigationPage.SetHasNavigationBar(this, true);
                DependencyService.Get<IStatusBar>().ShowStatusBar();
            }
            videoPlayer.Stop();
            base.OnDisappearing();
        }

        private void VideoPlayer_BufferingStart(object sender, EventArgs e)
        {

        }

        private void VideoPlayer_BufferingEnd(object sender, EventArgs e)
        {

        }
    }
}
