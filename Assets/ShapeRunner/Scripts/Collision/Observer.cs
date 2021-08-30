using ShapeRunner.World;
using UnityEngine;

namespace ShapeRunner.Collision
{
    public class Observer : MonoBehaviour
    {
        [SerializeField]
        private ObstacleSpawner _obstacleSpawner;
        [SerializeField]
        private Transform _character;
        [SerializeField]
        private GameObject _endGameWindow;

        private void Update()
        {
            if (CheckCollision())
            {
                _endGameWindow.SetActive(true);
            }
        }

        private bool CheckCollision()
        {
            foreach (var obstacle in _obstacleSpawner.ActiveObstacles)
            {
                var distance = _character.position - obstacle.transform.position;
                if (distance.sqrMagnitude <= 1f)
                {
                    return true;
                }
            }
            return false;
        }
    }
}