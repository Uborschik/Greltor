using UnityEngine;

namespace MyProject.Characters
{
    [CreateAssetMenu(fileName = "NewList", menuName = "CharactersList")]
    public class CharactersList : ScriptableObject
    {
        [field: SerializeField] public Entity[] Entities { get; private set; }
    }
}