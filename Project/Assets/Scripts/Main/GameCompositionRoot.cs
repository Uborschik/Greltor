using MyProject.Characters;
using MyProject.MainPlayer;
using MyProject.Managers;
using MyProject.Map;
using UnityEngine;

namespace MyProject.Main
{
    public class GameCompositionRoot : MonoBehaviour
    {
        [SerializeField] private CharactersList _list;
        [Space]
        [SerializeField] private MapController _mapController;
        [SerializeField] private Inputs _inputs;
        [SerializeField] private Player _player;
        [SerializeField] private CameraController _cameraController;

        private Spawner _spawner;

        private void Awake()
        {
            InstantiateSystems();
            InstallBindings();
            InitSystems();
        }

        private void InitSystems()
        {
            _mapController.Init();
            _spawner.Init(_mapController);
            _player = _spawner.CreateSingleEntity(_list).GetComponent<Player>();
            _player.Init(_inputs, _mapController);
            _cameraController.Init(_mapController);
        }

        private void InstallBindings()
        {
            
        }

        private void InstantiateSystems()
        {
            _spawner = new Spawner();
        }
    }
}