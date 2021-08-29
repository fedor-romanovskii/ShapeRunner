using ShapeRunner.Game.Services;
using ShapeRunner.Input;
using ShapeRunner.Settings;
using UnityEngine;

namespace ShapeRunner.Character
{
    public class Initializer : MonoBehaviour
    {
        [SerializeField]
        private Transform _playerPoint; 
        [SerializeField]
        private Character _prefab;

        private void Awake()
        {
            var loadingData = ServiceContainer.Instance.GetSingle<LoadingData>();
            var input = ServiceContainer.Instance.GetSingle<IInput>();
            var settings = ServiceContainer.Instance.GetSingle<SettingsProvider>();
            CreatePlayer(loadingData.CharacterConfig, input);
            loadingData.CharacterConfig.Accelerator.Setup(settings.Config.MaxSpeed, settings.Config.Acceleration);
        }

        private void CreatePlayer(CharacterConfig characterConfig, IInput input)
        {
            var charater = Instantiate(_prefab, _playerPoint.position, Quaternion.identity);
            charater.Setup(characterConfig.Accelerator, input);
        }
    }
}
