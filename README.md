# This is my first project with ASP.NET & MySQL web application
# To check .NET already install or not type this in command prompt
    dotnet --version
# This will return the version of the .NET alreadu install in the device

# If the code editer you use is VS Code, then you have to install "C#" extension by Microsoft and "C# Dev Kit" for support.
# Let's assume you already have .NET and all extensions install.
# And you need "ef" too. Check this exist in your device type this code in command prompt
    dotnet ef
# If not you have to install it. For that run this code in command prompt
    dotnet tool install --global dotnet-ef
# To run the project need run this two codes one time.
    dotnet ef migrations add InitialCreate
    dotnet ef database update
# And then to any time run the code type this code.
    dotnet run
