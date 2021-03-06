using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShapeRunner.World
{
    public class ObstacleSpawner : MonoBehaviour
    {
        private Obstacle[] _obstacles;
        private ObjectPool<Obstacle>[] _pools;
        private Coroutine _spawnRoutine;

        public List<Obstacle> ActiveObstacles { get; private set; }

        private void Awake()
        {
            ActiveObstacles = new List<Obstacle>();
        }

        public void SetupPrefabs(Obstacle[] obstacles)
        {
            _obstacles = obstacles;
            InitializePools();
        }

        public void StartSpawning(float minTime, float maxTime)
        {
            if (_spawnRoutine !=null)
            {
                StopCoroutine(_spawnRoutine);
            }
            _spawnRoutine = StartCoroutine(SpawnRoutine(minTime, maxTime));
        }

        private IEnumerator SpawnRoutine(float minTime, float maxTime)
        {
            while(true)
            {
                var delay = Random.Range(minTime, maxTime);
                yield return new WaitForSeconds(delay);
                SpawnRandomObstacle();
            }
        }

        private void SpawnRandomObstacle()
        {
            var randomPoolIndex = Random.Range(0, _pools.Length);
            var spawnedObstacle = _pools[randomPoolIndex].GetFreeElement();
            spawnedObstacle.transform.position = transform.position;
            ActiveObstacles.Add(spawnedObstacle);
        }

        public void DisableObstacle(Obstacle obstacle)
        {
            if (ActiveObstacles.Contains(obstacle))
            {
                ActiveObstacles.Remove(obstacle);
                obstacle.gameObject.SetActive(false);
            }
        }

        private void InitializePools()
        {
            _pools = new ObjectPool<Obstacle>[_obstacles.Length];

            for (int i = 0; i < _pools.Length; i++)
            {
                var obstacle = _obstacles[i];
                _pools[i] = new ObjectPool<Obstacle>(obstacle, 3, transform);
            }
        }
    }
}
