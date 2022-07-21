using MyProject.MainPlayer;
using MyProject.Map;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float zOffset;

    public void Init(MapController mapController)
    {
        var position = mapController.Grid.GetCentralCell().GetVector3Position();
        position.z = zOffset;
        transform.position = position;
    }
}
