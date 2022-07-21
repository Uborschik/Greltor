using System.Collections.Generic;
using UnityEngine;

namespace MyProject.Helpers
{
	public static class Directions2D
	{
		public static List<Vector2Int> cardinalDirectionsList = new List<Vector2Int>()
		{
			new Vector2Int( 0,  1),
			new Vector2Int( 1,  0),
			new Vector2Int( 0, -1),
			new Vector2Int(-1,  0)
		};

        public static List<Vector2Int> diagonalDirectionsList = new List<Vector2Int>
        {
            new Vector2Int( 1,  1),
            new Vector2Int(-1,  1),
            new Vector2Int(-1, -1),
            new Vector2Int( 1, -1)
        };

        public static List<Vector2Int> eightDirectionsList = new List<Vector2Int>
        {
            new Vector2Int( 0,  1),
            new Vector2Int( 1,  1),
            new Vector2Int( 1,  0),
            new Vector2Int( 1, -1),
            new Vector2Int( 0, -1),
            new Vector2Int(-1, -1),
            new Vector2Int(-1,  0),
            new Vector2Int(-1,  1)
        };

        public static Vector2Int GetRandomCardinalDirection()
		{
			return cardinalDirectionsList[Random.Range(0, cardinalDirectionsList.Count)];
		}

        public static Vector2Int GetRandomDiagonalDirection()
        {
            return cardinalDirectionsList[Random.Range(0, diagonalDirectionsList.Count)];
        }

        public static Vector2Int GetRandomEightDirection()
        {
            return cardinalDirectionsList[Random.Range(0, eightDirectionsList.Count)];
        }
    }
}