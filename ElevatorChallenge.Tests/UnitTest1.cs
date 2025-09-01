using ElevatorChallenge.Application;
using ElevatorChallenge.Core;

namespace ElevatorChallenge.Tests;

public class ElevatorTests
{
    [Fact]
    public void Elevator_Should_Add_Passengers_If_Capacity_Allows()
    {
        var elevator = new Elevator(1, 10);
        elevator.AddPassengers(5);
        Assert.Equal(5, elevator.PassengerCount);
    }

    [Fact]
    public void Elevator_Should_Not_Add_Passengers_If_Over_Capacity()
    {
        var elevator = new Elevator(1, 10);
        elevator.AddPassengers(10);
        Assert.Throws<InvalidOperationException>(() => elevator.AddPassengers(1));
    }

    [Fact]
    public void NearestElevatorDispatcher_Should_Assign_Nearest_Elevator()
    {
        var elevators = new List<Elevator> { new Elevator(1, 10, 1), new Elevator(2, 10, 5) };
        var building = new Building(10, elevators);
        var dispatcher = new NearestElevatorDispatcher();
        var assigned = dispatcher.AssignElevator(building, 3, 5);
        Assert.NotNull(assigned);
        Assert.Equal(1, assigned.Id);
    }
}