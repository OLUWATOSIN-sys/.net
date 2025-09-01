namespace ElevatorChallenge.Core;

public class Building
{
    public List<Elevator> Elevators { get; }
    public int NumberOfFloors { get; }
    public List<Floor> Floors { get; }

    public Building(int numberOfFloors, List<Elevator> elevators)
    {
        NumberOfFloors = numberOfFloors;
        Elevators = elevators;
        Floors = Enumerable.Range(1, numberOfFloors).Select(i => new Floor(i)).ToList();
    }
}

public class Floor
{
    public int Number { get; }
    public Queue<PassengerRequest> Requests { get; } = new Queue<PassengerRequest>();

    public Floor(int number)
    {
        Number = number;
    }
}

public class PassengerRequest
{
    public int Floor { get; }
    public int DestinationFloor { get; }
    public int PassengerCount { get; }

    public PassengerRequest(int floor, int destinationFloor, int passengerCount)
    {
        Floor = floor;
        DestinationFloor = destinationFloor;
        PassengerCount = passengerCount;
    }
}
