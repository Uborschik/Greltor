using MyProject.Characters;
using MyProject.Map;
using System;
using UnityEngine;

namespace MyProject.MainPlayer
{
    public class Player : Entity
    {
        private Inputs _inputs;
        private SpriteRenderer _spriteRenderer;

        public void Init(Inputs inputs, MapController mapController)
        {
            _inputs = inputs;
            _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
            MapController = mapController;
            Movement = GetComponent<Movement>();

            _spriteRenderer.sprite = Sprite;

            _inputs.OnLeftMouseButtonStarted += Test;
        }

        //#region EVENTS

        //private void OnEnable()
        //{
        //    _inputs.OnLeftMouseButtonStarted += Test;
        //}

        //private void OnDisable()
        //{
        //    _inputs.OnLeftMouseButtonStarted -= Test;
        //}

        //#endregion

        private void Test()
        {
            Movement.LClick(MapController);
        }

        private void Update()
        {
            Movement.MoveUpdate(_inputs.MoveVector, Speed);
        }
    }
}