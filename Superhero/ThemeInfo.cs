using Oqtane.Models;
using Oqtane.Themes;
using System.Collections.Generic;

namespace Oqtane.Theme.Bootswatch.Superhero
{
    public class ThemeInfo : ITheme
    {
        public Models.Theme Theme => new Models.Theme
        {
            Name = "Bootswatch Superhero",
            Version = "6.1.3",
            ThemeSettingsType = "Oqtane.Theme.Bootswatch.ThemeSettings, Oqtane.Theme.Bootswatch.Oqtane",
            ContainerSettingsType = "Oqtane.Theme.Bootswatch.ContainerSettings, Oqtane.Theme.Bootswatch.Oqtane",
            PackageName = "Oqtane.Theme.Bootswatch",
            Resources = new List<Resource>()
            {
		        // obtained from https://cdnjs.com/libraries
                new Stylesheet("https://cdnjs.cloudflare.com/ajax/libs/bootswatch/5.3.3/superhero/bootstrap.min.css", "sha512-yeFVFyLRIY48erNjFZ1uXiERPXN8izq4mBNe4iSgVYT0bq/ZiSsWwTlaSObBDeqR/+7MBw1g23iSpI9ru/qtGQ==", "anonymous"),
                new Stylesheet("Themes/Oqtane.Theme.Bootswatch/Theme.css"),
                new Stylesheet("Themes/Oqtane.Theme.Bootswatch/Cerulean.css"),
                new Script("https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.3/js/bootstrap.bundle.min.js", "sha512-7Pi/otdlbbCR+LnW+F7PwFcSDJOuUJB3OxtEHbg4vSMvzvJjde4Po1v4BR9Gdc9aXNUNFVUY+SK51wWT8WF0Gg==", "anonymous")
            }
        };
    }
}