using ElevatorChallenge.Core;

namespace ElevatorChallenge.Application;

public class NearestElevatorDispatcher : IElevatorDispatcher
{
    public Elevator? AssignElevator(Building building, int floor, int passengers)
    {
        var availableElevators = building.Elevators.Where(e => e.Status != ElevatorStatus.OutOfService && e.CanAcceptPassengers(passengers)).ToList();
        if (!availableElevators.Any())
        {
            return null;
        }

        var nearest = availableElevators.OrderBy(e => Math.Abs(e.CurrentFloor - floor)).First();
        return nearest;
    }
}
