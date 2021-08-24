using ShapeRunner.World;
using UnityEngine;

namespace ShapeRunner.UI
{
    public class WorldChoosePanel : ChoosePanel
    {
        [SerializeField]
        private ConfigContainer _container;

        private int _choosenConfigIndex;

        public WorldConfig Config => _container.Configs[_choosenConfigIndex];

        private void Awake()
        {
            _choosenConfigIndex = 0;
            UpdateLabel();
        }

        protected override void SwitchToNext()
        {
            _choosenConfigIndex++;
            if (_choosenConfigIndex >= _container.Configs.Length)
            {
                _choosenConfigIndex = 0;
            }
            UpdateLabel();
        }

        protected override void SwitchToPrevious()
        {
            _choosenConfigIndex--;
            if (_choosenConfigIndex < 0)
            {
                _choosenConfigIndex = _container.Configs.Length - 1;
            }
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            SetLabel(Config.name);
        }
    }
}