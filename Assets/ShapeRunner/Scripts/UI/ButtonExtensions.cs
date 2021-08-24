using UnityEngine.Events;
using UnityEngine.UI;

namespace ShapeRunner.UI
{
    public static class ButtonExtensions
    {
        public static void AddListener(this Button button, UnityAction call)
        {
            button.onClick.AddListener(call);
        }

        public static void RemoveListener(this Button button, UnityAction call)
        {
            button.onClick.RemoveListener(call);
        }
    }
}