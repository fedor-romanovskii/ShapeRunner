namespace ShapeRunner.World
{
    public class ObstacleSpawner
    {
        private Obstacle[] _obstacles;

        public void SetupPrefabs(Obstacle[] obstacles)
        {
            _obstacles = obstacles;
        }
    }
}
