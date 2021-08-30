using UnityEngine;

namespace ShapeRunner.Settings
{
    [CreateAssetMenu(menuName = "ShapeRunner/Settings/SettingsConfig")]
    public class SettingsConfig : ScriptableObject
    {
        [SerializeField]
        [Range(1f, 30f)]
        private float _maxSpeed;

        [SerializeField]
        [Range(0.1f, 10f)]
        private float _acceleration;

        [SerializeField]
        [Range(1f, 10f)]
        private float _minSpawnRange;

        [SerializeField]
        [Range(1f, 50f)]
        private float _maxSpawnRange;

        public float MaxSpeed => _maxSpeed;
        public float Acceleration => _acceleration;
        public float MinSpawnRange => _minSpawnRange;
        public float MaxSpawnRange => _maxSpawnRange;

        private void OnValidate()
        {
            if (_maxSpawnRange < _minSpawnRange)
            {
                _maxSpawnRange = _minSpawnRange;
            }
        }
    }
}
