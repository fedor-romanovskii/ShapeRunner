using ShapeRunner.Game.Services;
using ShapeRunner.Settings;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ShapeRunner.Game
{
    public class Bootstrap : MonoBehaviour
    {
        private const string NextScene = "MainMenu";

        private void Awake()
        {
            RegisterChildServices();
            RegisterServices();
            DontDestroyOnLoad(this);
            LoadNextScene();
        }

        private void RegisterChildServices()
        {
            foreach (var service in GetComponentsInChildren<IService>())
            {
                var type = service.GetType();
                ServiceContainer.Instance.RegisterAsSingle(service);
            }
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