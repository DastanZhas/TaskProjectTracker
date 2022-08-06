# TaskProjectTracker
Install the following packages using Package Manager Console (PowerShell):
```C#
Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore
Install-Package Microsoft.AspNetCore.Mvc.NewtonsoftJson
Install-Package Microsoft.EntityFrameworkCore.Design
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design
Install-Package Swashbuckle.AspNetCore.SwaggerUI
Install-Package Swashbuckle.AspNetCore.SwaggerGen
Install-Package Npgsql.EntityFrameworkCore.PostgreSQL.Design
Install-Package Npgsql.EntityFrameworkCore.PostgreSQL
```

Make migrations using package manager console:
```C#
add-migration "migration1"
update-database
```

This web application is created using Asp.net core MVC and EntityFramework.
And I have deployed this application to my own domain and web server in AWS EC2 Instance: https://ektuvredu.online
I have used this domain name for my diploma project
