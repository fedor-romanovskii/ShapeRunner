using UnityEngine;

namespace ShapeRunner.World
{
    public class ObstacleSpawner : MonoBehaviour
    {
        private Obstacle[] _obstacles;
        private ObjectPool<Obstacle>[] _pools;

        public void SetupPrefabs(Obstacle[] obstacles)
        {
            _obstacles = obstacles;
            InitializePools();
        }

        private void InitializePools()
        {
            _pools = new ObjectPool<Obstacle>[_obstacles.Length];

            for (int i = 0; i < _pools.Length; i++)
            {
                var obstacle = _obstacles[i];
                _pools[i] = new ObjectPool<Obstacle>(obstacle, 3, transform);
            }
        }
    }
}
