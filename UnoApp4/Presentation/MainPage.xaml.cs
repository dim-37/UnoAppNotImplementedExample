using Windows.Media.Core;
using Windows.Storage.Streams;


namespace UnoApp4.Presentation
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();



        }

        public async Task Test (object e)
        {
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Assets/test.mp4"));

            var stream = await file.OpenAsync(FileAccessMode.Read);

            mediaPlayer.Source = MediaSource.CreateFromStream(stream, "mp4");

        }
    }
}