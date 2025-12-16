# Reverse Difference Calculator

A web application that calculates the difference between a number and its reverse. Built with ASP.NET Core Razor Pages.

## Features

- Enter a whole number and calculate the difference between the original number and its reverse
- Input validation to ensure only whole numbers are accepted
- Clean, responsive UI built with Bootstrap

## Prerequisites

Before running this application, ensure you have the following installed:

- [.NET SDK 10.0](https://dotnet.microsoft.com/download) or later
- A code editor (Visual Studio, Visual Studio Code, or Rider)

## Running the Application Locally

### Option 1: Using .NET CLI (Recommended)

1. **Navigate to the project directory:**
   ```bash
   cd ReverseDifferenceCalculator
   ```

2. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

3. **Build the project:**
   ```bash
   dotnet build
   ```

4. **Run the application:**
   ```bash
   dotnet run
   ```

5. **Open your browser:**
   - The application will start and display the URL (typically `https://localhost:5001` or `http://localhost:5000`)
   - Open the displayed URL in your web browser

### Option 2: Using Visual Studio

1. Open the project folder in Visual Studio
2. Press `F5` or click the "Run" button
3. The application will launch in your default browser

### Option 3: Using Visual Studio Code

1. Open the project folder in VS Code
2. Open the terminal (`` Ctrl+` ``)
3. Run `dotnet run`
4. Open the displayed URL in your browser

## Project Structure

```
ReverseDifferenceCalculator/
├── Pages/
│   ├── Index.cshtml          # Main calculator page
│   ├── Index.cshtml.cs       # Page model with calculation logic
│   └── Shared/
│       └── _Layout.cshtml    # Main layout template
├── wwwroot/                   # Static files (CSS, JS, images)
│   ├── css/
│   ├── js/
│   └── images/
│       └── RDApp.png         # Application logo
├── Program.cs                 # Application entry point
└── ReverseDifferenceCalculator.csproj
```

## How It Works

1. Enter a whole number in the input field
2. Click "Calculate Difference"
3. The application will:
   - Reverse the number (e.g., 123 becomes 321)
   - Calculate the absolute difference between the original and reversed number
   - Display the results

## Troubleshooting

### Port Already in Use

If you encounter a port conflict, you can specify a different port:

```bash
dotnet run --urls "http://localhost:5002"
```

### Missing Dependencies

If you get dependency errors, try:

```bash
dotnet restore
dotnet clean
dotnet build
```

## License

Copyright © 2025 - ReverseDifferenceCalculator

