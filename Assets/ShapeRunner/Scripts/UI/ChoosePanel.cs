using UnityEngine;
using UnityEngine.UI;

namespace ShapeRunner.UI
{
    public class ChoosePanel : MonoBehaviour
    {
        [SerializeField]
        private Button _previous;
        
        [SerializeField]
        private Button _next;

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

        private void SwitchToPrevious()
        {
            Debug.Log("ChoosePanel : previous");
        }

        private void SwitchToNext()
        {
            Debug.Log("ChoosePanel : next");
        }
    }
}