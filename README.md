# t5-pr1-ArnauPascual7

# Esquema ORM



# GitHub Project

Projecte -> https://github.com/users/ArnauPascual7/projects/7

Hi ha una branca nova per a cada configuració de cada apartat del projecte, al tenir una branca per a cada configuració puc centrar-me a configurar aquella part, i en acabar posar-me amb un altre branca per a configurar una altra cosa diferent.

#### FileRevision

Aquesta branca és per a la revisió de fitxers del projecte, al haver duplicat el projecte de la pràtica anterior aquest conté arxius que no s'ha utilitzat, aixií que s'han eliminat.

#### Entities-Model

Aquesta branca és per a la configuració de les Entitats o Models del projecte, com les seves propietats i la seva validació.

#### EnergyIndicatorsController

Aquesta branca és per a la configuració del Controlador de EnergyIndicators, a més de la condiguració de les seves vistes Index, Create, Delete, Details i Edit.

#### DbContext

Aquesta branca és per a la configuració del DbContext.

#### WaterConsumptionController

Aquesta branca al igual que la de EnergyIndicatorsController és per a la configuració del controlador de WaterConsumption i les seves vistes.

#### SimulationsController

Aqauesta branca és per al mateix que les altres dues de controladors, però per a Simulations.

#### ProjectConfiguration

Aquesta branca és per a la configuració general del projecte, com la configuració del [appsettings.json](EcoEnergyRazorPagesSolution/EcoEnergyRazorPages/appsettings.json), el [Program.cs](EcoEnergyRazorPagesSolution/EcoEnergyRazorPages/Program.cs) o l'arxiu del [projecte](EcoEnergyRazorPagesSolution/EcoEnergyRazorPages/EcoEnergyRazorPages.csproj).

#### CodeCleaning

Aquesta branca és per a la neteja de codi, errors mínims o warnings sense solucionar o neteja de codi en general com moure strings o valors a constants o moure mètodes a a una HelperClass.

# Solució del sistema

La Solució conté el projecte principal de RazorPages. Dins d'aquest hi ha algunes noves carpetes que no venen amb el projecte de Razor Pages de forma predeterminada:

[Controllers](EcoEnergyRazorPagesSolution/EcoEnergyRazorPages/Controllers): Aquest directori conté els controladors de les pagines de Simulacions, Consums d'aigua i Indicadors d'energia.

[Data](EcoEnergyRazorPagesSolution/EcoEnergyRazorPages/Data): Aquest directori només conté el [DbContext](EcoEnergyRazorPagesSolution/EcoEnergyRazorPages/Data/AppDbContext.cs) i la seva configuració, així com els mètodes OnConfiguring() i OnModelCreating().

[Migrations](EcoEnergyRazorPagesSolution/EcoEnergyRazorPages/Migrations): Aquest directori es generat automàticament al generar una migració a la base de dades, les migracions posteriors a la inicial també es generaran en aquest directori. També conté un snapshot del DbContext.

[Model](EcoEnergyRazorPagesSolution/EcoEnergyRazorPages/Model): Aquest directori conté les classes per a poder llegir els arxius i gestionar la base de dades.

[ModelData](EcoEnergyRazorPagesSolution/EcoEnergyRazorPages/ModelData): Aquest directori conté els arxius CSV per a inicialitzar i restaurar la base de dades.

[Pages](EcoEnergyRazorPagesSolution/EcoEnergyRazorPages/Pages): Aquest directori ja be amb el projecte de forma predeterminada, però al utilitzar els controllers, es creen les pagies dins de [Views](EcoEnergyRazorPagesSolution/EcoEnergyRazorPages/Views) en comptes de Pages,  així que en aquest projecte només s'ha utilitzat per al layout y el Index.

[Tools](EcoEnergyRazorPagesSolution/EcoEnergyRazorPages/Tools): Aquest directori conté dues helper classes amb funcionalitats per a ajudar en el maneig dels fitxers, llegir i escriure, i inicialitzar la base de dades.

De forma predeterminada hi ha el directori [Pages](EcoEnergyRazorPagesSolution/EcoEnergyRazorPages/Pages), aquest conté totes les pàgina de la web. També dins del direcotir [wwwroot](EcoEnergyRazorPagesSolution/EcoEnergyRazorPages/wwwroot) hi ha una carpeta [images](EcoEnergyRazorPagesSolution/EcoEnergyRazorPages/wwwroot/images) que conté les imatges utilitzades en la web.

# Bibliografia

> Michal Ciechan. (15/4/2010). Best method to store Enum in Database. StackOverflow. Recuperat el 23/3/2025 de https://stackoverflow.com/questions/2646498/best-method-to-store-enum-in-database.

> Hellcat8. (1/6/2015). ASP.NET MVC 5 - Get current view's name (Razor .cshtml side). StackOverflow. Recuperat el 24/3/2025 de https://stackoverflow.com/questions/31156473/asp-net-mvc-5-get-current-views-name-razor-cshtml-side.

> lucas. (5/8/2016). asp-controller and asp-action attributes not working. StackOverflow. Recuperat el 24/3/2025 de https://stackoverflow.com/questions/38797393/asp-controller-and-asp-action-attributes-not-working.

> Sense Autor. (Sense data). Tutorial: Implement CRUD Functionality with the Entity Framework in ASP.NET MVC. Microsoft. Recuperat el 25/3/2025 de https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/implementing-basic-crud-functionality-with-the-entity-framework-in-asp-net-mvc-application#overpost.

> iamtravisw. (3/1/2019). ASP.NET Core 2.1 Razor Form, Post not reaching Controller. StackOverflow. Recuperat el 25/3/2025 de https://stackoverflow.com/questions/54026020/asp-net-core-2-1-razor-form-post-not-reaching-controller.

> JerZaw. (4/1/2022). How to seed data in .NET Core 6 with Entity Framework?. StackOverflow. Recuperat el 26/3/2025 de https://stackoverflow.com/questions/70581816/how-to-seed-data-in-net-core-6-with-entity-framework.

> ZZZ Projects. (17/2/2023). EF Core Seed Data. Learn Entity Framework Core. Recuperat el 26/3/2025 de https://www.learnentityframeworkcore.com/migrations/seeding.

> Jonathan. (5/11/2011). How is the AND/OR operator represented as in Regular Expressions?. StackOverflow. Recuperat el 27/3/2025 de https://stackoverflow.com/questions/8020848/how-is-the-and-or-operator-represented-as-in-regular-expressions.

> brother. (11/3/2012). Regex: ignore case sensitivity. StackOverflow. Recuperat el 27/3/2025 de https://stackoverflow.com/questions/9655164/regex-ignore-case-sensitivity.

> Sense Autor. (Sense data). Part 8 of tutorial series on Razor Pages. Microsoft. Recuperat el 27/3/2025 de https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/validation?view=aspnetcore-9.0&tabs=visual-studio.

> Sense Autor. (Sense data). C# .NET and SQL Server supported data types. Microsoft. Recuperat el 27/3/2025 de https://learn.microsoft.com/en-us/sql/language-extensions/how-to/c-sharp-to-sql-data-types?view=sql-server-ver16.
