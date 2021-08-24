namespace ShapeRunner.Character.Accelerator
{
    public class Linear : IAccelerator
    {
        public float GetIncreasedSpeed(float deltaTime)
        {
            return 1f;
        }
    }
}