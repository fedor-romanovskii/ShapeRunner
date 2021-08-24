using UnityEngine;

namespace ShapeRunner.Character
{
    [CreateAssetMenu(menuName = "ShapeRunner/Character/CharacterConfigContainer")]
    public class ConfigContainer : ScriptableObject
    {
        [SerializeField]
        private CharacterConfig[] _configs;

        public CharacterConfig[] Configs => _configs;
    }
}