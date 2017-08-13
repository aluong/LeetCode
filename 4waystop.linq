<Query Kind="Program" />

void Main()
{
	AddCar(1, Direction.South);
	AddCar(2, Direction.South);
	AddCar(3, Direction.South);
	AddCar(4, Direction.East);
	AddCar(5, Direction.East);
	AddCar(6, Direction.North);
	AddCar(7, Direction.West);
	

	for (int i = 0; i < 7; i++)
	{
		GetNextCar().Dump();
	}
}

Dictionary<Direction, Queue<Car>> queues = new Dictionary<Direction, Queue<Car>>();
Queue<Direction> priorty = new Queue<Direction>();

class Car
{
	public int Id { get; set; }
}

enum Direction
{
	North,
	South,
	East,
	West
}

void AddCar(int id, Direction dir)
{
	var car = new Car { Id = id };
	if (!priorty.Contains(dir))
	{
		var queue = new Queue<Car>();
		queue.Enqueue(car);
		
		queues.Add(dir, queue);		
		priorty.Enqueue(dir);
	}
	else
	{
		queues[dir].Enqueue(car);
	}
	
}

int GetNextCar()
{
	if (priorty.Count <= 0)
	{
		return -1;
	}
	
	var dir = priorty.Dequeue();
	var car = queues[dir].Dequeue();

	if (queues[dir].Count > 0)
	{
		priorty.Enqueue(dir);
	}
	
	return car.Id;
}
