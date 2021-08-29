using ShapeRunner.Game.Services;
using UnityEngine;

namespace ShapeRunner.Settings
{
    public class SettingsProvider : MonoBehaviour, IService
    {
        [SerializeField]
        private SettingsConfig _config;

        public SettingsConfig Config => _config;
    }
}