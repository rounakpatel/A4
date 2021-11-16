using System;

// Make sure to uncomment the ToString methods when you are ready!

namespace A4.Task2Interface
{
	interface ICarryPassengers
	{
		string CarryPassengers();
	}
	class Ship
	{

			public double Displacement { get; }

			public Ship(double displacement)
			{
				Displacement = displacement;
			}


			public string CarryPassengers()
			{
				return "This type of ship don't carry passengers.";
			}

			public override string ToString()
			{
				return $"A ship that displaces {Math.Round(Displacement, 2)} tons of water";
			}
		}
	}

	class CruiseShip : ICarryPassengers
	{
		// TODO: IMPLEMENT THIS CLASS (it should inherit from Ship as well as extend ICarryPassenger)
		
		public CruiseShip(double displacement, int numPassengers) { }

		//public override string ToString() => CarryPassengers();
	}

	class BigRig
	{
		// TODO: IMPLEMENT THIS CLASS

		//public override string ToString() => $"A vehicle with {NumTires} tires"; 
	}

	class TourBus : ICarryPassengers
	{
		// TODO: IMPLEMENT THIS CLASS (it should inherit from BigRig as well as extend ICarryPassenger)
		
		public TourBus(int numTires, int numPassengers) { }

		//public override string ToString() => CarryPassengers();
	}
}
