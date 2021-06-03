using System;
using Windows.Media.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GrantsMediaPlayerDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void openFile_Click(object sender, RoutedEventArgs e)
        {
            await SetLocalMedia();
        }

        async private System.Threading.Tasks.Task SetLocalMedia()
        {
            var openPicker = new Windows.Storage.Pickers.FileOpenPicker();

            openPicker.FileTypeFilter.Add(".wmv");
            openPicker.FileTypeFilter.Add(".mp4");
            openPicker.FileTypeFilter.Add(".wma");
            openPicker.FileTypeFilter.Add(".mp3");

            var file = await openPicker.PickSingleFileAsync();

            // mediaPlayerElement is a MediaPlayerElement control defined in XAML
            if (file != null)
            {
                mediaPlayerElement.Source = MediaSource.CreateFromStorageFile(file);

                mediaPlayerElement.MediaPlayer.Play();
            }
           
        }

        private void pictureSize_Click(object sender, RoutedEventArgs e)
        {
            switch (mediaPlayerElement.Stretch)
            {
                case Stretch.Fill:
                    mediaPlayerElement.Stretch = Stretch.None;
                    break;
                case Stretch.None:
                    mediaPlayerElement.Stretch = Stretch.Uniform;
                    break;
                case Stretch.Uniform:
                    mediaPlayerElement.Stretch = Stretch.UniformToFill;
                    break;
                case Stretch.UniformToFill:
                    mediaPlayerElement.Stretch = Stretch.Fill;
                    break;
                default:
                    break;
            }
        }

        private void pauseFile_Click(object sender, RoutedEventArgs e)
        {
            if (mediaPlayerElement != null)
            {
                mediaPlayerElement.MediaPlayer.Pause();

            }
           
        }

        private void stopFile_Click(object sender, RoutedEventArgs e)
        {
            if (mediaPlayerElement != null)
            {
                mediaPlayerElement.MediaPlayer.Pause();
                mediaPlayerElement.Source = null;
            }
            
        }

        private void playFile_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayerElement.MediaPlayer.Play();
        }
    }
}
