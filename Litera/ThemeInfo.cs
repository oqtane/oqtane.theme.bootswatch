using Oqtane.Themes;

namespace Oqtane.Theme.Bootswatch.Litera
{
    public class ThemeInfo : ITheme
    {
        public Models.Theme Theme => new Models.Theme
        {
            Name = "Bootswatch Litera Theme",
            Version = "1.0.1",
            ContainerSettingsType = "Oqtane.Theme.Bootswatch.ContainerSettings, Oqtane.Theme.Bootswatch.Oqtane",
            PackageName = "Oqtane.Theme.Bootswatch"
        };
    }
}