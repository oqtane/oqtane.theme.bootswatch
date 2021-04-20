# Oqtane Bootswatch Theme Collection

Oqtane allows developers to create themes which are rendered by the framework dynamically at run\-time. 

These themes are based on Bootswatch \- https://bootswatch.com/

A custom theme is comprised of razor components \- some which inherit from ThemeBase \(theme components\) and ContainerBase \(container components\).

Theme components are the structure and layout for your pages\. They include embedded theme controls such as Menu, Login, etc\.\.\. Theme components must contain Pane components which indicate locations where modules will be dynamically injected at runtime\.

Container components are containers for individual module instances\. They include embedded container controls such as ModuleActions, ModuleTitle, etc\.\.\. Container components must contain a ModuleInstance component which is where the module output will be dynamically rendered at runtime\.

Themes contain an implementation of the ITheme interface which provides metadata about the theme\.

Themes have static resources such as images or CSS files which will be located in the wwwroot folder with a subfolder name matching the theme name\.

These themes utilize inheritance so that the razor components for each individual theme all inherit from the Default theme\. This consolidates all of the HTML markup within a minimal number of components to simplify maintenance.

A sample of what the various themes look like is shown below:

### Cerulean

![Cerulean](Screenshots/Cerulean.png)

### Cosmo

![Cosmo](Screenshots/Cosmo.png)

### Darkly

![Darkly](Screenshots/Darkly.png)

### Default

![Default](Screenshots/Default.png)

### Flatly

![Flatly](Screenshots/Flatly.png)

### Journal

![Journal](Screenshots/Journal.png)

### Litera

![Litera](Screenshots/Litera.png)

### Lumen

![Lumen](Screenshots/Lumen.png)

### Lux

![Lux](Screenshots/Lux.png)

### Materia

![Materia](Screenshots/Materia.png)

### Minty

![Minty](Screenshots/Minty.png)

### Pulse

![Pulse](Screenshots/Pulse.png)

### Sandstone

![Sandstone](Screenshots/Sandstone.png)

### Simplex

![Simplex](Screenshots/Simplex.png)

### Sketchy

![Sketchy](Screenshots/Sketchy.png)

### Slate

![Slate](Screenshots/Slate.png)

### Solar

![Solar](Screenshots/Solar.png)

### Spacelab

![Spacelab](Screenshots/Spacelab.png)

### Superhero

![Superhero](Screenshots/Superhero.png)

### United

![United](Screenshots/United.png)

### Yeti

![Yeti](Screenshots/Yeti.png)
