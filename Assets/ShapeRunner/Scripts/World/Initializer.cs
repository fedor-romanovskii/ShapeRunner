using ShapeRunner.Character;
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
        [SerializeField]
        private Mover _mover;

        private void Awake()
        {
            var loadingData = ServiceContainer.Instance.GetSingle<LoadingData>();
            SetConfig(loadingData.WorldConfig, loadingData.CharacterConfig);
            var settings = ServiceContainer.Instance.GetSingle<SettingsProvider>();
            _obstacleSpawner.StartSpawning(settings.Config.MinSpawnRange, settings.Config.MaxSpawnRange);
        }

        private void SetConfig(WorldConfig worldConfig, CharacterConfig characterConfig)
        {
            _background.color = worldConfig.Background;
            _obstacleSpawner.SetupPrefabs(worldConfig.Obstacles);
            _mover.Setup(characterConfig.Accelerator);
        }
    }
}
