using UnityEngine;

namespace ShapeRunner.Input
{
    public class TestInput : UserInput
    {
        protected override bool CheckJumpInput()
        {
            if (UnityEngine.Input.GetKeyUp(KeyCode.Space))
            {
                return true;
            }
            
            return false;
        }
    }
}