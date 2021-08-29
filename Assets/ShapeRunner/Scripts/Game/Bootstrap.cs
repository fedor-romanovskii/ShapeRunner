using ShapeRunner.Game.Services;
using ShapeRunner.Input;
using ShapeRunner.Settings;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ShapeRunner.Game
{
    public class Bootstrap : MonoBehaviour
    {
        private const string NextScene = "MainMenu";

        [SerializeField]
        private UserInput _userInput;
        [SerializeField]
        private SettingsProvider _settingsProvider;

        private void Awake()
        {
            RegisterChildServices();
            RegisterServices();
            DontDestroyOnLoad(this);
            LoadNextScene();
        }

        private void RegisterChildServices()
        {
            ServiceContainer.Instance.RegisterAsSingle<IInput>(_userInput);
            ServiceContainer.Instance.RegisterAsSingle(_settingsProvider);
        }

        private void RegisterServices()
        {
            ServiceContainer.Instance.RegisterAsSingle(new LoadingData());
        }

        private void LoadNextScene()
        {
            SceneManager.LoadScene(NextScene);
        }
    }
}