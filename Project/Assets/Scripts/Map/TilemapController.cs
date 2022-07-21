using UnityEngine;
using UnityEngine.Tilemaps;

namespace MyProject.Map
{
    public class TilemapController : MonoBehaviour
    {
        [SerializeField] private Tilemap[] tilemaps;
        [SerializeField] private TileBase[] tiles;

        public void PaintTiles(MyGrid grid)
        {
            for (int x = 0; x < grid.GetWidth(); x++)
            {
                for (int y = 0; y < grid.GetHeight(); y++)
                {
                    var position = grid.GetArray()[x, y].GetVector3Position();

                    var TilemapIndex = 0;

                    var TileIndex = 0;

                    var intPosition = tilemaps[TilemapIndex].WorldToCell(position);

                    if (position == grid.GetCentralCell().GetVector3Position())
                    {
                        PaintSingleTile(intPosition, TilemapIndex, 1);
                    }
                    else
                    {
                        PaintSingleTile(intPosition, TilemapIndex, TileIndex);
                    }
                }
            }
        }

        public void PaintSingleTile(Vector3Int intPosition, int tilemapIndex, int tileIndex)
        {
            var tilemap = tilemapIndex >= 0 ? tilemaps[tilemapIndex] : null;
            var tile = tileIndex >= 0 ? tiles[tileIndex] : null;

            tilemap.SetTile(intPosition, tile);
        }
    }
}