using UnityEngine;

namespace ShapeRunner.UI
{
    public abstract class ConfigContainer<TConfig> : ScriptableObject, IConfigContainer<TConfig>
        where TConfig : ScriptableObject
    {
        [SerializeField]
        private TConfig[] _configs;

        public TConfig[] Configs => _configs;
    }
}