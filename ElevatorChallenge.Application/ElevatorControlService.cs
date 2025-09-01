using ElevatorChallenge.Core;

namespace ElevatorChallenge.Application;

public class ElevatorControlService
{
    private readonly Building _building;
    private readonly IElevatorDispatcher _dispatcher;

    public ElevatorControlService(Building building, IElevatorDispatcher dispatcher)
    {
        _building = building;
        _dispatcher = dispatcher;
    }

    public void CallElevator(int floor, int passengers)
    {
        var elevator = _dispatcher.AssignElevator(_building, floor, passengers);
        if (elevator != null)
        {
            elevator.AddDestination(floor);
            Console.WriteLine($"Elevator {elevator.Id} assigned to floor {floor}.");
        }
        else
        {
            Console.WriteLine("No available elevator for the request.");
        }
    }

    public void UpdateElevators()
    {
        foreach (var elevator in _building.Elevators)
        {
            elevator.MoveToNextDestination();
        }
    }

    public void DisplayStatus()
    {
        Console.WriteLine("Elevator Status:");
        foreach (var elevator in _building.Elevators)
        {
            Console.WriteLine(elevator.ToString());
        }
    }
}
