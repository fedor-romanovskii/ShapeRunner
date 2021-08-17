using UnityEngine;

namespace ShapeRunner.World
{
    [CreateAssetMenu(menuName = "ShapeRunner/World/WorldConfig")]
    public class WorldConfig : ScriptableObject
    {
        [SerializeField]
        private Color _background;

        [SerializeField]
        private Obstacle[] _obstacles;

        [SerializeField]
        [Range(1f, 10f)]
        private float _gravity;

        public Color Background => _background;
        public Obstacle[] Obstacles => _obstacles;
        public float Gravity => _gravity;
    }
}
