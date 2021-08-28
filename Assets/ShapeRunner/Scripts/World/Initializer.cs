using ShapeRunner.Game.Services;
using ShapeRunner.Settings;
using UnityEngine;

namespace ShapeRunner.World
{
    public class Initializer : MonoBehaviour
    {
        [SerializeField]
        private SpriteRenderer _background;
        [SerializeField]
        private ObstacleSpawner _obstacleSpawner;

        private void Awake()
        {
            var loadingData = ServiceContainer.Instance.GetSingle<LoadingData>();
            SetConfig(loadingData.WorldConfig);
        }

        private void SetConfig(WorldConfig worldConfig)
        {
            _background.color = worldConfig.Background;
            _obstacleSpawner.SetupPrefabs(worldConfig.Obstacles);
        }
    }
}
