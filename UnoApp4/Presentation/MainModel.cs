using Windows.Media.Core;
using Windows.Media.Playback;

namespace UnoApp4.Presentation
{
    public partial record MainModel
    {
        private INavigator _navigator;

        public MainModel(
            IStringLocalizer localizer,
            IOptions<AppConfig> appInfo,
            INavigator navigator)
        {
            _navigator = navigator;
            Title = "Main";
            Title += $" - {localizer["ApplicationName"]}";
            Title += $" - {appInfo?.Value?.Environment}";

        }

        public string? Title { get; }

        public IState<string> Name => State<string>.Value(this, () => string.Empty);

    }
}