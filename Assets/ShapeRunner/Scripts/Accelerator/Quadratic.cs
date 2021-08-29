using UnityEngine;

namespace ShapeRunner.Accelerator
{
    public class Quadratic : Accelerator
    {
        public override void Increase(float deltaTime)
        {
            CurrentSpeed = Mathf.Clamp(CurrentSpeed + deltaTime * _acceleration * _acceleration, 0f, _maxSpeed);
        }
    }
}