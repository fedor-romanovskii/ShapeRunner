using ShapeRunner.Game.Services;
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
            CreatePlayer(loadingData.CharacterConfig);
        }

        private void CreatePlayer(CharacterConfig characterConfig)
        {
            var charater = Instantiate(_prefab, _playerPoint.position, Quaternion.identity);
            charater.Setup(characterConfig.Accelerator);
        }
    }
}
