using ElevatorChallenge.Application;
using ElevatorChallenge.Core;

class Program
{
    static void Main(string[] args)
    {
        // Initialize building with 10 floors and 3 elevators
        var elevators = new List<Elevator>
        {
            new Elevator(1, 10),
            new Elevator(2, 10),
            new Elevator(3, 10)
        };
        var building = new Building(10, elevators);
        var dispatcher = new NearestElevatorDispatcher();
        var controlService = new ElevatorControlService(building, dispatcher);

        Console.WriteLine("Welcome to the Elevator Challenge!");
        Console.WriteLine("Commands:");
        Console.WriteLine("call <floor> <passengers> - Call elevator to floor with passengers");
        Console.WriteLine("status - Display elevator status");
        Console.WriteLine("update - Move elevators to next destinations");
        Console.WriteLine("exit - Exit the program");

        while (true)
        {
            Console.Write("> ");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) continue;

            var parts = input.Split(' ');
            var command = parts[0].ToLower();

            switch (command)
            {
                case "call":
                    if (parts.Length >= 3 && int.TryParse(parts[1], out int floor) && int.TryParse(parts[2], out int passengers))
                    {
                        controlService.CallElevator(floor, passengers);
                    }
                    else
                    {
                        Console.WriteLine("Invalid command. Use: call <floor> <passengers>");
                    }
                    break;
                case "status":
                    controlService.DisplayStatus();
                    break;
                case "update":
                    controlService.UpdateElevators();
                    Console.WriteLine("Elevators updated.");
                    break;
                case "exit":
                    return;
                default:
                    Console.WriteLine("Unknown command.");
                    break;
            }
        }
    }
}
