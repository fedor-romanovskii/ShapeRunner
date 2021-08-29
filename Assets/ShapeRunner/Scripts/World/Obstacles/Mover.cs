using System.Collections.Generic;
using ShapeRunner.Accelerator;
using UnityEngine;

namespace ShapeRunner.World
{
    public class Mover : MonoBehaviour
    {
        [SerializeField]
        private float _removePositionX;
        [SerializeField]
        private ObstacleSpawner _obstacleSpawner;
        private IAccelerator _accelerator;
        private Vector3 _movingDirection = Vector3.left;
        private List<Obstacle> _obstacles => _obstacleSpawner.ActiveObstacles;

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            foreach (var obstacle in _obstacles)
            {
                obstacle.transform.position += _movingDirection * _accelerator.CurrentSpeed * Time.deltaTime;
                if (obstacle.transform.position.x <= _removePositionX)
                {
                    _obstacleSpawner.DisableObstacle(obstacle);
                }
            }
        }
    }
}