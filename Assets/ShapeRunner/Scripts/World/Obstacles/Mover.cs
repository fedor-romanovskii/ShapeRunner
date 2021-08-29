using System;
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
        private Queue<Obstacle> _obstaclesToRemove = new Queue<Obstacle>();

        private void Update()
        {
            Move();
        }

        public void Setup(IAccelerator accelerator)
        {
            _accelerator = accelerator;
        }

        private void Move()
        {
            foreach (var obstacle in _obstacles)
            {
                obstacle.transform.position += _movingDirection * _accelerator.CurrentSpeed * Time.deltaTime;
                if (obstacle.transform.position.x <= _removePositionX)
                {
                    _obstaclesToRemove.Enqueue(obstacle);
                }
            }
            
            while(_obstaclesToRemove.Count > 0)
            {
                var obstacle = _obstaclesToRemove.Dequeue();
                _obstacleSpawner.DisableObstacle(obstacle);
            }
        }
    }
}