namespace ElevatorChallenge.Core;

public enum Direction
{
    Up,
    Down,
    Stationary
}

public enum ElevatorStatus
{
    Moving,
    Stationary,
    OutOfService
}

public class Elevator
{
    public int Id { get; }
    public int CurrentFloor { get; private set; }
    public Direction Direction { get; private set; }
    public ElevatorStatus Status { get; private set; }
    public int PassengerCount { get; private set; }
    public int Capacity { get; }
    public Queue<int> DestinationRequests { get; } = new Queue<int>();

    public Elevator(int id, int capacity, int startingFloor = 1)
    {
        Id = id;
        Capacity = capacity;
        CurrentFloor = startingFloor;
        Direction = Direction.Stationary;
        Status = ElevatorStatus.Stationary;
        PassengerCount = 0;
    }

    public bool CanAcceptPassengers(int count)
    {
        return PassengerCount + count <= Capacity;
    }

    public void AddPassengers(int count)
    {
        if (CanAcceptPassengers(count))
        {
            PassengerCount += count;
        }
        else
        {
            throw new InvalidOperationException("Elevator capacity exceeded.");
        }
    }

    public void RemovePassengers(int count)
    {
        if (count <= PassengerCount)
        {
            PassengerCount -= count;
        }
        else
        {
            throw new InvalidOperationException("Cannot remove more passengers than present.");
        }
    }

    public void AddDestination(int floor)
    {
        if (!DestinationRequests.Contains(floor))
        {
            DestinationRequests.Enqueue(floor);
        }
    }

    public void MoveToNextDestination()
    {
        if (DestinationRequests.Count > 0)
        {
            int nextFloor = DestinationRequests.Dequeue();
            Direction = nextFloor > CurrentFloor ? Direction.Up : nextFloor < CurrentFloor ? Direction.Down : Direction.Stationary;
            Status = ElevatorStatus.Moving;
            // Simulate movement
            CurrentFloor = nextFloor;
            Status = ElevatorStatus.Stationary;
            Direction = Direction.Stationary;
        }
    }

    public override string ToString()
    {
        return $"Elevator {Id}: Floor {CurrentFloor}, Direction {Direction}, Status {Status}, Passengers {PassengerCount}/{Capacity}";
    }
}
