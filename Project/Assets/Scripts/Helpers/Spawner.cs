using MyProject.Characters;
using MyProject.Map;
using UnityEngine;

namespace MyProject.Managers
{
    public class Spawner
    {
        private MapController _mapController;

        public void Init(MapController mapController)
        {
            _mapController = mapController;
        }

        public GameObject CreateSingleEntity(CharactersList list)
        {
            var prefab = list.Entities[0].gameObject;
            var cellOffset = new Vector3(0.5f, 0.5f);
            var position = _mapController.Grid.GetRandomCell().GetVector3Position() + cellOffset;
            var rotation = Quaternion.identity;
            _mapController.Grid.GetCell(position).AddContent(prefab);

            return Object.Instantiate(prefab, position, rotation);
        }
    }
}