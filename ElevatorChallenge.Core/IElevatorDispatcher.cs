namespace ElevatorChallenge.Core;

public interface IElevatorDispatcher
{
    Elevator? AssignElevator(Building building, int floor, int passengers);
}
