using ShapeRunner.Accelerator;
using ShapeRunner.Input;
using UnityEngine;

namespace ShapeRunner.Character
{
    public class Character : MonoBehaviour
    {
        [SerializeField]
        private SpriteRenderer _renderer;
        [SerializeField]
        private Jumper _jumper;
        [SerializeField]
        private ColorChanger _colorChanger;

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

        public void Setup(IAccelerator accelerator, IInput input, Sprite shapePicture)
        {
            _accelerator = accelerator;
            _input = input;
            _renderer.sprite = shapePicture;
        }

        private void OnJump()
        {
            _jumper.Jump();
            _colorChanger.ChangeToRandomColor();
        }
    }
}