using MyProject.MainPlayer;
using MyProject.Map;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyProject.Characters
{
    public abstract class Entity : MonoBehaviour
    {
        [SerializeField] protected Sprite Sprite;
        [SerializeField] protected int MaxHealth;
        [SerializeField] protected int Speed = 3;
        protected MapController MapController;
        protected Movement Movement;
        protected Vector2 Position;
    }
}