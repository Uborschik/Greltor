using UnityEngine;
using Random = UnityEngine.Random;

namespace MyProject.Map
{
    public class MyGrid
    {
        private int _width;
        private int _height;
        private Cell[,] _gridArray;

        public MyGrid(int width, int height)
        {
            _width = width % 2 == 0 ? width + 1 : width;
            _height = height % 2 == 0 ? height + 1 : height;
            _gridArray = new Cell[_width, _height];

            CreateGrid();
        }

        private void CreateGrid()
        {
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    var position = new Vector2Int(x, y);
                    _gridArray[x, y] = new Cell(position);
                }
            }
        }

        #region Help

        public Cell[,] GetArray()
        {
            return _gridArray;
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetHeight()
        {
            return _height;
        }

        public Cell GetCell(int x, int y)
        {
            if (IsValid(x, y))
            {
                return _gridArray[x, y];
            }
            else
            {
                return _gridArray[0, 0];
            }
        }

        public Cell GetCell(Vector2 position)
        {
            GetXY(position, out int x, out int y);
            return GetCell(x, y);
        }

        public Cell GetCentralCell()
        {
            return GetCell(_width / 2, _height / 2);
        }

        public Cell GetRandomCell()
        {
            GetRandomXY(out int x, out int y);
            return GetCell(x, y);
        }

        #endregion

        #region IsValid

        public bool IsValid(int x, int y)
        {
            return x >= 0 && x < _width
                && y >= 0 && y < _height;
        }

        public bool IsValid(Vector3 position)
        {
            GetXY(position, out int x, out int y);
            return IsValid(x, y);
        }

        #endregion

        #region CalculatePositions

        private void GetXY(Vector2 position, out int x, out int y)
        {
            x = (int)position.x;
            y = (int)position.y;
        }

        private void GetRandomXY(out int x, out int y)
        {
            x = Random.Range(0, _width);
            y = Random.Range(0, _height);
        }

        #endregion

    }
}