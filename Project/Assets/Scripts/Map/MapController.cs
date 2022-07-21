using UnityEngine;

namespace MyProject.Map
{
    public class MapController : MonoBehaviour
    {
        public TilemapController TilemapVisualizer { get; private set; }
        public MyGrid Grid { get; private set; }
        [field: SerializeField] public int Width { get; private set; }
        [field: SerializeField] public int Height { get; private set; }

        public void Init()
        {
            TilemapVisualizer = GetComponent<TilemapController>();
            Generate();
        }

        public void Generate()
        {
            Grid = new MyGrid(Width, Height);

            TilemapVisualizer.PaintTiles(Grid);
        }
    }
}