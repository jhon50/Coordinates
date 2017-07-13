using System;
namespace Coordenadas
{
	public class App
	{
		public App()
		{
		}

		public static void Start()
		{
			startConsole();
		}

		private static void startConsole()
		{
			//bool exec = true;
			Console.WriteLine("Insert starting coordinate");
			String stringCoordinate = Console.ReadLine();
			//Coordinate coordinate = new Coordinate();
			//coordinate.ParseCoordFromString(stringCoordinate);
			//Position position = new Position(coordinate);

			//while(exec)
			//{
			//	Console.WriteLine("Insert new directions");
			//	stringCoordinate = Console.ReadLine();
			//	coordinate.ParseCoordFromString(stringCoordinate);
			//	coordinate.Show();
			//	//position.MoveTo(coordinate);
			//	//position.Show();
			//}
		}
	}
}
