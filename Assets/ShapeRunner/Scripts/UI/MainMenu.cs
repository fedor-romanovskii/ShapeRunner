using UnityEngine;
using UnityEngine.UI;

namespace ShapeRunner.UI
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField]
        private Button _play;

        private void OnEnable()
        {
            _play.AddListener(Play);
        }

        private void OnDisable()
        {
            _play.RemoveListener(Play);
        }

        private void Play()
        {
            Debug.Log("MainMenu : Play");
        }
    }
}