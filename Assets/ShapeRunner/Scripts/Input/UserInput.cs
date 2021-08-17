using System;
using UnityEngine;

namespace ShapeRunner.Input
{
    public abstract class UserInput : MonoBehaviour, IInput
    {
        public event Action Jump;

        private void Update()
        {
            if (CheckJumpInput())
            {
                Jump?.Invoke();
            }
        }

        protected abstract bool CheckJumpInput();
    }
}
