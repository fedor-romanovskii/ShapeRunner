using UnityEngine;
using UnityEngine.UI;

namespace ShapeRunner.UI
{
    public abstract class ChoosePanel : MonoBehaviour
    {
        [SerializeField]
        private Button _previous;
        [SerializeField]
        private Button _next;
        [SerializeField]
        private Text _label;

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

        protected abstract void SwitchToPrevious();
        protected abstract void SwitchToNext();
    }
}