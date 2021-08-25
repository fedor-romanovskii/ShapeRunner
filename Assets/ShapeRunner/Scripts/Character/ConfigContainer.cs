using ShapeRunner.UI;
using UnityEngine;

namespace ShapeRunner.Character
{
    [CreateAssetMenu(menuName = "ShapeRunner/Character/CharacterConfigContainer")]
    public class ConfigContainer : ScriptableObject, IConfigContainer<CharacterConfig>
    {
        [SerializeField]
        private CharacterConfig[] _configs;

        public CharacterConfig[] Configs => _configs;
    }
}