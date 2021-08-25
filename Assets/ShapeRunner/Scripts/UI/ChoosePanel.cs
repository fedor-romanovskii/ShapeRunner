using UnityEngine;
using UnityEngine.UI;

namespace ShapeRunner.UI
{
    public abstract class ChoosePanel<TContainer, TConfig> : MonoBehaviour
        where TContainer : IConfigContainer<TConfig>
        where TConfig : ScriptableObject
    {
        [SerializeField]
        private Button _previous;
        [SerializeField]
        private Button _next;
        [SerializeField]
        private Text _label;
        [SerializeField]
        private TContainer _container;

        private int _choosenConfigIndex;

        public TConfig Config => _container.Configs[_choosenConfigIndex];

        private void Awake()
        {
            _choosenConfigIndex = 0;
            UpdateLabel();
        }

        private void OnEnable()
        {
            _previous.AddListener(SwitchToPrevious);
            _next.AddListener(SwitchToNext);
        }

        private void OnDisable()
        {
            _previous.RemoveListener(SwitchToPrevious);
            _next.RemoveListener(SwitchToNext);
        }

        protected void SetLabel(string text)
        {
            _label.text = text;
        }

        private void SwitchToPrevious()
        {
            _choosenConfigIndex--;
            if (_choosenConfigIndex < 0)
            {
                _choosenConfigIndex = _container.Configs.Length - 1;
            }
            UpdateLabel();
        }

        private void SwitchToNext()
        {
            _choosenConfigIndex++;
            if (_choosenConfigIndex >= _container.Configs.Length)
            {
                _choosenConfigIndex = 0;
            }
            UpdateLabel();
        }

        protected void UpdateLabel()
        {
            SetLabel(Config.name);
        }
    }

    public interface IConfigContainer<TConfig> where TConfig : ScriptableObject
    {
        TConfig[] Configs { get; }
    }
}