using UnityEngine;

namespace ShapeRunner.Accelerator
{
    public class Linear : Accelerator
    {
        public override void Increase(float deltaTime)
        {
            CurrentSpeed = Mathf.Clamp(CurrentSpeed + deltaTime * _acceleration, 0f, _maxSpeed);
        }
    }
}