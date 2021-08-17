using UInput = UnityEngine.Input;

namespace ShapeRunner.Input
{
    public class TouchInput : UserInput
    {
        protected override bool CheckJumpInput()
        {
            if (UInput.touchCount > 0)
            {
                var touch = UInput.GetTouch(0);

                if (touch.phase == UnityEngine.TouchPhase.Began)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
