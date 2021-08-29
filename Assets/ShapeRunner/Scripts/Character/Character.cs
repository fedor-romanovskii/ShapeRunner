using ShapeRunner.Accelerator;
using ShapeRunner.Game.Services;
using ShapeRunner.Input;
using UnityEngine;

namespace ShapeRunner.Character
{
    public class Character : MonoBehaviour
    {
        private IInput _input;
        private IAccelerator _accelerator;

        private void Start()
        {
            _input.Jump += OnJump;
        }

        private void OnDestroy()
        {
            _input.Jump -= OnJump;
        }

        private void Update()
        {
            _accelerator.Increase(Time.deltaTime);
        }

        public void Setup(IAccelerator accelerator, IInput input)
        {
            _accelerator = accelerator;
            _input = input;
        }

        private void OnJump()
        {
            Debug.Log("Character : Jump");
        }
    }
}