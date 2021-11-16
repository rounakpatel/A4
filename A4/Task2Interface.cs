using System;


namespace A4.Task2Interface
{
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
			return $"Ship that displaces {Math.Round(Displacement, 2)} tons of water";
		}
	}

	class CruiseShip : Ship, ICarryPassengers
	{


		private int NumPassengers;

		public CruiseShip(double displacement, int numPassengers) : base(displacement)
		{
			NumPassengers = numPassengers;
		}

		public string CarryPassengers()
		{
			return $"{base.ToString()}   and is carrying {NumPassengers} passengers on a Caribbean Cruise";
		}
		public override string ToString() => CarryPassengers();
	}

	class BigRig
	{

		public int NumTires;

		public BigRig(int numTires)
		{
			NumTires = numTires;
		}
		public string CarryPassengers()
		{
			return "This type of vehicle don't carry passengers.";
		}



		public override string ToString() => $"A vehicle with {NumTires} tires";
	}

	class TourBus : BigRig, ICarryPassengers
	{

		private int numPassengers;
		public TourBus(int numTires, int numPassengers) : base(numTires)
		{
			this.numPassengers = numPassengers;
		}

		public string CarryPassengers()
		{
			return $"{base.ToString()} and is carrying {numPassengers} passengers on cross country tour.";
		}
		public override string ToString() => CarryPassengers();
	}
}
