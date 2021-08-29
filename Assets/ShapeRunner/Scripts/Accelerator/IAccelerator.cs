namespace ShapeRunner.Accelerator
{
    public interface IAccelerator
    {
        float CurrentSpeed { get; }
        void Setup(float maxSpeed, float acceleration);
        void Increase(float deltaTime);
    }
}