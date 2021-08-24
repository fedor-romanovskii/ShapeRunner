using UnityEngine;

namespace ShapeRunner.World
{
    [CreateAssetMenu(menuName = "ShapeRunner/World/WorldConfigContainer")]
    public class ConfigContainer : ScriptableObject
    {
        [SerializeField]
        private WorldConfig[] _configs;

        public WorldConfig[] Configs => _configs;
    }
}
