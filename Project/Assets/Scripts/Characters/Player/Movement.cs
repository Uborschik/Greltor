using System;
using MyProject.Map;
using UnityEngine;

namespace MyProject.MainPlayer
{
    public class Movement : MonoBehaviour
    {
        public void MoveUpdate(Vector2 direction, int speed)
        {
            var newDirection = (Vector2)transform.position + direction;
            transform.position = Vector2.MoveTowards(transform.position, newDirection, speed * Time.deltaTime);
        }

        public void LClick(MapController mapController)
        {
            var position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var obj = mapController.Grid.GetCell(position).GetContent();

            if(obj != null)
            {
                Debug.Log(position);
                Debug.Log(obj.name);
            }
            else
            {
                Debug.Log(mapController.Grid.GetCell(position).Position);
                Debug.LogError("Is empty");
            }
        }
    }
}