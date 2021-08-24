using UnityEngine;

namespace ShapeRunner.World
{
    public class Initializer
    {
        [SerializeField]
        private SpriteRenderer _background;
        [SerializeField]
        private ObstacleSpawner _obstacleSpawner;

        public void SetConfig(WorldConfig worldConfig)
        {
            _background.color = worldConfig.Background;
            _obstacleSpawner.SetupPrefabs(worldConfig.Obstacles);
        }
    }
}
