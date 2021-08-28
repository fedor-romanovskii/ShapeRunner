using UnityEngine;

namespace ShapeRunner.World
{
    public class ObstacleSpawner : MonoBehaviour
    {
        private Obstacle[] _obstacles;

        public void SetupPrefabs(Obstacle[] obstacles)
        {
            _obstacles = obstacles;
        }
    }
}
