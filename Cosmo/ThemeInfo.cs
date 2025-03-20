using Oqtane.Models;
using Oqtane.Themes;
using System.Collections.Generic;

namespace Oqtane.Theme.Bootswatch.Cosmo
{
    public class ThemeInfo : ITheme
    {
        public Models.Theme Theme => new Models.Theme
        {
            Name = "Bootswatch Cosmo",
            Version = "6.0.0",
            ThemeSettingsType = "Oqtane.Theme.Bootswatch.ThemeSettings, Oqtane.Theme.Bootswatch.Oqtane",
            ContainerSettingsType = "Oqtane.Theme.Bootswatch.ContainerSettings, Oqtane.Theme.Bootswatch.Oqtane",
            PackageName = "Oqtane.Theme.Bootswatch",
            Resources = new List<Resource>()
            {
		        // obtained from https://cdnjs.com/libraries
                new Stylesheet("https://cdnjs.cloudflare.com/ajax/libs/bootswatch/5.3.3/cosmo/bootstrap.min.css", "sha512-PU+mnI7iaSDt/G/adHVcQOX2I+K3bQ27kwHJQ1rPq5iqQvHuHSdJOUU/TmPcUsyUGrfAxK+Z4rnx/SL+qCmBNQ==", "anonymous"),
                new Stylesheet("Themes/Oqtane.Theme.Bootswatch/Theme.css"),
                new Stylesheet("Themes/Oqtane.Theme.Bootswatch/Cerulean.css"),
                new Script("https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.3/js/bootstrap.min.js", "sha512-ykZ1QQr0Jy/4ZkvKuqWn4iF3lqPZyij9iRv6sGqLRdTPkY69YX6+7wvVGmsdBbiIfN/8OdsI7HABjvEok6ZopQ==", "anonymous")
            }
        };
    }
}