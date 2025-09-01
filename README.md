# DVT Elevator Challenge - My Submission

Hi! This is my solution for the DVT Elevator Challenge. I built a C# console app that simulates elevators in a building. It's designed to be efficient, safe, and easy to use, following best practices like Clean Architecture and SOLID principles.

## What It Does

Imagine a building with floors and elevators. This app lets you call elevators, check their status, and move them around via simple commands. It picks the nearest elevator to minimize wait times and handles passenger limits to avoid overloading.

## Key Features

- Real-time status of elevators (floor, direction, passengers).
- Call elevators with passenger counts.
- Nearest-elevator dispatching.
- Capacity checks and error handling.
- Extensible for new elevator types.
- Console-based interaction.

## Architecture

I used Clean Architecture:
- **Core**: Domain models and interfaces.
- **Application**: Business logic and services.
- **Infrastructure**: External stuff (minimal here).
- **Presentation**: Console app.
- **Tests**: Unit tests with xUnit.

This keeps the code organized and easy to maintain.

## SOLID Principles

- **SRP**: Each class has one job.
- **OCP**: Add new features without changing old code.
- **LSP**: Swap implementations easily.
- **ISP**: Specific interfaces.
- **DIP**: Depend on abstractions.

## Tech Used

- C# with .NET 8.0.
- xUnit for testing.
- Queues and lists for data.
- Microsoft coding standards.

## How to Run

1. Install .NET 8.0 if you don't have it.
2. Run `dotnet build` in the project folder.
3. Run `dotnet run --project ElevatorChallenge.Presentation`.
4. For tests: `dotnet test`.

## Usage

Commands:
- `call <floor> <passengers>`: e.g., `call 5 3`
- `status`: Show elevator statuses.
- `update`: Move elevators.
- `exit`: Quit.

Example:
```
> call 3 2
Elevator 1 assigned.
> status
Elevator 1: Floor 3, Up, Moving, 2/10
```

## Testing

Unit tests cover elevator logic, dispatching, and building setup. Run `dotnet test` – all pass.

