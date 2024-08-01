# MyFirstApi

Welcome to **MyFirstApi**, a C# Web API project template. This README will guide you through the steps to get started, install necessary dependencies, and set up your development environment in Visual Studio Code.

## Table of Contents

1. [Getting Started](#getting-started)
2. [Prerequisites](#prerequisites)
3. [Installation](#installation)
4. [Running the Application](#running-the-application)
5. [Project Structure](#project-structure)
6. [Contributing](#contributing)
7. [License](#license)

## Getting Started

These instructions will help you set up your development environment and run the project on your local machine for development and testing purposes.

## Prerequisites

Make sure you have the following software installed on your machine:

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [Visual Studio Code](https://code.visualstudio.com/)
- [Git](https://git-scm.com/)

### VSCode Extensions

To enhance your development experience, install the following Visual Studio Code extensions:

- [C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) - Provides C# language support.
- [Debugger for Chrome](https://marketplace.visualstudio.com/items?itemName=msjsdiag.debugger-for-chrome) - For debugging your front-end code.
- [REST Client](https://marketplace.visualstudio.com/items?itemName=humao.rest-client) - For testing your API endpoints.

## Installation

### Cloning the Repository

First, clone the repository from GitHub:

```bash
git clone https://github.com/yourusername/MyFirstApi.git
cd MyFirstApi
```

### Installing Dependencies
Restore the necessary dependencies by running:

```bash
dotnet restore
```

### Running the Application
Development Server
To start the development server, run:

```bash
dotnet run
```

* The API will be available at http://localhost:5000.

### Swagger UI
Swagger UI is available at http://localhost:5000/swagger and provides an interface to explore and test your API endpoints.

### Project Structure

MyFirstApi/
├── Controllers/
│   ├── HelloWorldController.cs
│   └── anotherController.cs
├── Properties/
│   └── launchSettings.json
├── Program.cs
├── Startup.cs
├── MyFirstApi.csproj
└── README.md

- Controllers/: Contains the API controllers.
- Properties/: Contains project settings and configurations.
- Program.cs: Entry point of the application.
- Startup.cs: Configures services and the app's request pipeline.
- MyFirstApi.csproj: Project file that defines the project and its dependencies.
- README.md: Project documentation.

### Contributing
We welcome contributions to enhance the project! Please follow these steps:

1. Fork the repository.
2. Create a new branch (git checkout -b feature/your-feature).
3. Commit your changes (git commit -m 'Add your feature').
4. Push to the branch (git push origin feature/your-feature).
Open a pull request.
5. Pull request will be reviewed and approved 

### License
This project is licensed under the MIT License - see the LICENSE file for details.

### API Documentation

### Tests

### Deployment

### FAQ
