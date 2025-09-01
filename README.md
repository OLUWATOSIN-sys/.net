# DVT Elevator Challenge - My Technical Assessment Submission

Hey there! This is my take on the DVT Elevator Challenge – a fun yet challenging technical assessment where I built a C# console app to simulate elevator operations in a busy building. Think of it as a mini control system for managing elevators, passengers, and floors, all while keeping things efficient, safe, and easy to expand. I poured in my best practices for clean code, solid design, and real-world usability, making sure it feels like something you'd find in a real building management system.

## What This App Does

Picture a tall building with multiple floors and a few elevators zipping around. This app lets you interact with it right from the console – call an elevator, check statuses, and watch them move. It's all about optimizing how people get from point A to B, minimizing waits, and handling the chaos of multiple requests. Plus, it's built to grow: want to add fancy glass elevators or freight ones? No problem – the design makes it super straightforward.

## Key Features I Implemented

- **Live Elevator Updates**: See exactly where each elevator is, which way it's going, and how many people are inside – all in real-time.
- **Easy Interaction**: Type simple commands to call an elevator or get the latest scoop on what's happening.
- **Scalable Setup**: Works for any number of floors and elevators – tweak the config and you're good.
- **Smart Dispatching**: Uses a simple but effective algorithm to pick the closest available elevator, cutting down on wait times.
- **Safety First**: Checks passenger limits to avoid overloading, and handles edge cases gracefully.
- **Future-Proof**: The code is set up so you can plug in new elevator types without rewriting everything.
- **Real-Time Feel**: Simulates elevator movement step-by-step, giving that dynamic feel.
- **Bulletproof Inputs**: Validates everything you enter, with helpful error messages if something's off.

## How I Structured It (Clean Architecture Style)

I went with Clean Architecture because it keeps things organized and maintainable – like having a tidy toolbox where everything has its place. Here's the breakdown:

- **Core Layer**: This is the heart – domain models like the Elevator and Building classes, plus interfaces for things like dispatching. It's all about the business rules that don't change.
- **Application Layer**: Here are the brains – services that handle the logic, like assigning elevators or controlling movements. It's where the "what to do" decisions happen.
- **Infrastructure Layer**: For external stuff, like if we wanted to save data or connect to other systems (kept light for now).
- **Presentation Layer**: The console app you interact with – keeps the UI separate from the guts.
- **Tests Layer**: Unit tests to make sure everything works as expected, using xUnit.

This setup means high cohesion (related stuff stays together) and low coupling (changes in one part don't break others), making it a breeze to test and update.

## SOLID Principles – My Guiding Stars

I stuck closely to SOLID principles to make the code robust and flexible:

- **Single Responsibility Principle (SRP)**: Each class does one job well – like the Elevator class just handles its own state, while the Dispatcher focuses on assignments.
- **Open/Closed Principle (OCP)**: You can add new features (like a different dispatching strategy) without touching existing code – thanks to interfaces!
- **Liskov Substitution Principle (LSP)**: Swap out implementations seamlessly – any dispatcher can replace another without issues.
- **Interface Segregation Principle (ISP)**: Interfaces are tailored and not bloated – just what's needed for each use case.
- **Dependency Inversion Principle (DIP)**: Code depends on abstractions, not specifics, so it's easy to swap parts in and out.

These aren't just buzzwords; they make the code feel natural and easy to work with.

## Tech Stack and Best Practices

- **Built With**: C# on .NET 8.0 – modern, powerful, and perfect for this kind of sim.
- **Testing**: xUnit for unit tests that cover the key logic, ensuring reliability.
- **Algorithms**: A straightforward O(n) search for the nearest elevator – efficient for small to medium setups.
- **Data Handling**: Queues for passenger requests and lists for elevators/floors – simple and effective.
- **Coding Standards**: Followed Microsoft's guidelines with clear names, comments, and consistent style.
- **Validation**: Double-checks inputs for floors and passengers, with friendly error messages.
- **User Experience**: Clear feedback so you always know what's happening – no guessing!

## Getting Started – Let's Run This!

Ready to see it in action? Here's how:

1. **Make Sure You Have .NET 8.0**: If not, grab it from Microsoft's site.
2. **Build It**: Open a terminal in the project folder and run `dotnet build`.
3. **Launch**: Type `dotnet run --project ElevatorChallenge.Presentation` and hit enter.
4. **Test It Out**: Run `dotnet test` to see the unit tests pass.

## How to Use It

Once it's running, you'll see a prompt. Here are the commands:

- `call <floor> <passengers>`: Summon an elevator – e.g., `call 5 3` means 3 people want to go to floor 5.
- `status`: Get a quick overview of all elevators.
- `update`: Let the elevators move to their next stops.
- `exit`: Wrap it up.

Example run:
```
> call 3 2
Elevator 1 assigned to floor 3.
> status
Elevator Status:
Elevator 1: Floor 3, Direction Up, Status Moving, Passengers 2/10
> update
Elevators updated.
```

It's interactive and responsive – feels like controlling a real system!

## Testing – Because Quality Matters

I wrote unit tests to cover the essentials:
- How elevators handle capacity and movement.
- The dispatcher's logic for picking elevators.
- Building and floor setups.

Just run `dotnet test` – everything passes, giving you confidence in the code.

## GitHub Submission – Dotting the I's

To make this a proper submission:
- **Public Repo**: Make sure it's public on GitHub.
- **.gitignore**: Set up to ignore build files like bin/ and obj/.
- **Commits**: Used Git for all changes with clear messages.
- **Main Branch**: Builds without issues.
- **This README**: Your guide to everything.
- **Extras**: Ready for branching or CI if you want to go further.

## What's Next? Ideas for Improvement

This is solid, but here's what I'd love to add:
- Async features for smoother real-time simulation.
- A graphical UI with WPF or Blazor for a visual twist.
- Saving logs to a database.
- Smarter dispatching with priorities.
- Hooking into external APIs for more realism.
