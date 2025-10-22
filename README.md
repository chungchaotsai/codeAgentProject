# Nine1 NMQ Dashboard

A Blazor-based dashboard application for Nine1 NMQ system monitoring and management.

## Project Structure

```
Nine1.NMQ.Dashboard/
├── src/
│   ├── Nine1.NMQ.Dashboard.Blazor/      # Main Blazor web application
│   ├── Nine1.NMQ.Dashboard.Core/        # Core business logic and interfaces
│   └── Nine1.NMQ.Dashboard.Infrastructure/ # Infrastructure implementations
├── tests/
│   └── Nine1.NMQ.Dashboard.Tests/       # Unit and integration tests
├── Directory.Build.props                 # Shared build properties
├── Directory.Build.targets              # Shared build targets
└── Nine1.NMQ.Dashboard.sln              # Solution file
```

## Architecture

The project follows Clean Architecture principles:

- **Core**: Contains domain models, interfaces, and business logic
- **Infrastructure**: Implements interfaces from Core, includes services and data access
- **Blazor**: Presentation layer with Blazor Server components

## Prerequisites

- .NET 9.0 SDK or later
- Visual Studio 2022 / VS Code / JetBrains Rider (optional)

## Getting Started

### Build the Solution

```bash
dotnet build
```

### Run Tests

```bash
dotnet test
```

### Run the Application

```bash
cd src/Nine1.NMQ.Dashboard.Blazor
dotnet run
```

The application will be available at:
- https://localhost:5001
- http://localhost:5000

## Dependency Injection

The project uses dependency injection for loose coupling. Services are registered in:

- `Infrastructure/DependencyInjection/ServiceCollectionExtensions.cs`: Infrastructure services
- `Program.cs`: Application services and middleware

### Adding New Services

1. Define interface in `Core/Interfaces/`
2. Implement interface in `Infrastructure/Services/`
3. Register in `ServiceCollectionExtensions.AddInfrastructureServices()`
4. Inject into components/pages using `@inject`

## Build Configuration

### Directory.Build.props

Contains shared properties for all projects:
- Target framework
- Language version
- Nullable reference types
- Code analysis settings
- Assembly metadata

### Directory.Build.targets

Contains shared build targets and customizations.

## Code Style

The project uses `.editorconfig` for consistent code formatting across the team. Key conventions:

- 4 spaces for C# and Razor files
- 2 spaces for JSON, XML, and YAML
- UTF-8 encoding
- PascalCase for types and members
- Interface names start with 'I'

## Development

### Project References

- Blazor → Core, Infrastructure
- Infrastructure → Core
- Tests → All projects

### Adding New Features

1. Create models/interfaces in Core
2. Implement services in Infrastructure
3. Register services in DI
4. Create/update Blazor components
5. Add tests

## Contributing

1. Follow the established project structure
2. Maintain clean architecture boundaries
3. Add unit tests for new functionality
4. Follow code style guidelines
5. Update documentation as needed

## License

Copyright © Nine1 2025
