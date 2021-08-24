using ShapeRunner.Settings;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ShapeRunner.UI
{
    public class MainMenu : MonoBehaviour
    {
        private const string GameSceneName = "Game";

        [SerializeField]
        private Button _play;
        [SerializeField]
        private WorldChoosePanel _worldChoosePanel;
        [SerializeField]
        private CharacterChoosePanel _characterChoosePanel;

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
            SetupLoadingData();
            SceneManager.LoadScene(GameSceneName);
        }

        private void SetupLoadingData()
        {
            LoadingData.CharacterConfig = _characterChoosePanel.Config;
            LoadingData.WorldConfig = _worldChoosePanel.Config;
        }
    }
}