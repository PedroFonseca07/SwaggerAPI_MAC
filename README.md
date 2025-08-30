# SwaggerApi

This is an ASP.NET Core Web API project with integrated Swagger documentation.

## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Visual Studio Code](https://code.visualstudio.com/) or any compatible IDE

## Getting Started

### Restore Dependencies

```sh
dotnet restore
```

### Build the Project

```sh
dotnet build
```

### Run the Project

```sh
dotnet run
```

The API will be available at:

- http://localhost:5089 (HTTP)
- https://localhost:7149 (HTTPS)

### Access Swagger UI

Navigate to [http://localhost:5089](http://localhost:5089) or [https://localhost:7149](https://localhost:7149) in your browser. The Swagger UI will be displayed at the root path.

## Project Structure

- `Controllers/` - API controllers (e.g., [`HelloController.cs`](Controllers/HelloController.cs))
- [`Program.cs`](Program.cs) - Main entry point and configuration
- `appsettings.json` / `appsettings.Development.json` - Configuration files
- `Properties/launchSettings.json` - Launch profiles

## Useful Commands

- **Run unit tests (if any):**
  ```sh
  dotnet test
  ```
- **Publish for deployment:**
  ```sh
  dotnet publish -c Release -o ./publish
  ```

## API Documentation

Swagger UI provides interactive API documentation. You can test endpoints directly from the browser.

---

Feel free to customize this README for your specific needs.
