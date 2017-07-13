using NUnit.Framework;
using System;
using Coordenadas;
namespace CoordenadasTest
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void TestCase()
		{
			Coordinate coord = new Coordinate(new char[] { 'N', '1' });
			Position position = new Position(coord);


			// inicializa deslocamentos
			Coordinate coord2 = new Coordinate(new char[]{ 'N', '4' }); 

			// inicializa posição final
			Coordinate coord3 = new Coordinate(new char[] { 'N', '6' });
			Position finalPosition = new Position(coord3);

			// deslocamento
			position.GoTo(coord2);

			Assert.AreEqual(position.Coordinates(), finalPosition.Coordinates(),
			                "precisam ser iguais");
			
		}
	}
}
