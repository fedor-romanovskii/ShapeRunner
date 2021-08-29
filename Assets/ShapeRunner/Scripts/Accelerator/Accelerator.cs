namespace ShapeRunner.Accelerator
{
    public abstract class Accelerator : IAccelerator
    {
        protected float _maxSpeed;
        protected float _acceleration;

        public float CurrentSpeed { get; protected set; }

        public void Setup(float maxSpeed, float acceleration)
        {
            _maxSpeed = maxSpeed;
            _acceleration = acceleration;
            CurrentSpeed = 0f;
        }

        public abstract void Increase(float deltaTime);
    }
}