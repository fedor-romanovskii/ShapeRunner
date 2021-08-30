using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ShapeRunner.UI
{
    public class EndGameWindow : MonoBehaviour
    {
        private const string MenuSceneName = "MainMenu";

        [SerializeField]
        private Button _next;

        private void OnEnable()
        {
            Time.timeScale = 0f;
            _next.AddListener(GoToMenu);
        }

        private void OnDisable()
        {
            _next.RemoveListener(GoToMenu);
            Time.timeScale = 1f;
        }

        private void GoToMenu()
        {
            SceneManager.LoadScene(MenuSceneName);
        }
    }
}