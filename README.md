# This is my first project with ASP.NET & MySQL web application
# To check if the .NET already install or not type this in command prompt
    dotnet --version
# This will return the version of the .NET alreadu install in the device

# If the code editer you use is VS Code, then you have to install "C#" extension by Microsoft and "C# Dev Kit" for support.
# Let's assume you already have .NET and all extensions install.
# And you need "ef" too. Check this exist in your device type this code in command prompt
    dotnet ef
# If not you have to install it. For that run this code in command prompt
    dotnet tool install --global dotnet-ef
# To run this code you need 3 more packeges. Those are can be install with running this codes in command prompt
    dotnet add package Microsoft.EntityFrameworkCore --version 8.0.0
    dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.0
    dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.0

    If do not see a  problem( did not use for this project)
    dotnet add package MySql.EntityFrameworkCore --version 8.0.33

    But if see a dificulty with MySql.EntityFrameworkCore, install Pomelo packege. ( use for this project )
    dotnet add package Pomelo.EntityFrameworkCore.MySql --version 8.0.0

# To run the project need run this two codes one time.
    dotnet ef migrations add InitialCreate
    dotnet ef database update
# And then to any time run the code type this code.
    dotnet run
    
