using ShapeRunner.Accelerator;
using UnityEngine;

namespace ShapeRunner.Character
{
    public class Character : MonoBehaviour
    {
        private IAccelerator _accelerator;

        private void Update()
        {
            _accelerator.Increase(Time.deltaTime);
        }

        public void Setup(IAccelerator accelerator)
        {
            _accelerator = accelerator;
        }
    }
}