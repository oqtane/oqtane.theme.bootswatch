del "*.nupkg"
"..\oqtane.framework\oqtane.package\nuget.exe" pack Oqtane.Theme.Bootswatch.nuspec 
XCOPY "*.nupkg" "..\oqtane.framework\Oqtane.Server\wwwroot\Themes\" /Y
