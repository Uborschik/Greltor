using System.Collections.Generic;
using UnityEngine;

namespace MyProject.Map
{
    public struct Cell
    {
        public Vector2Int Position { get; private set; }
        public List<GameObject> ContentList { get; private set; }

        public Cell(Vector2Int position, List<GameObject> contentList = null)
        {
            Position = position;
            ContentList = new List<GameObject>();
        }

        #region Help

        public Vector3 GetVector3Position()
        {
            return new Vector3(Position.x, Position.y);
        }

        public GameObject GetContent()
        {
            foreach (var item in ContentList)
            {
                return item;
            }
            return null;
        }

        public void AddContent(GameObject content)
        {
            ContentList.Add(content);
        }

        #endregion
    }
}