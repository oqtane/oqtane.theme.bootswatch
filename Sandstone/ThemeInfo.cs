using Oqtane.Themes;

namespace Oqtane.Theme.Bootswatch.Sandstone
{
    public class ThemeInfo : ITheme
    {
        public Models.Theme Theme => new Models.Theme
        {
            Name = "Bootswatch Sandstone Theme",
            Version = "1.0.1",
            ContainerSettingsType = "Oqtane.Theme.Bootswatch.ContainerSettings, Oqtane.Theme.Bootswatch.Oqtane",
            PackageName = "Oqtane.Theme.Bootswatch"
        };
    }
}