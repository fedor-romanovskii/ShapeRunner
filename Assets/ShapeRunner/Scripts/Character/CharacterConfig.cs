using ShapeRunner.Accelerator;
using UnityEngine;

namespace ShapeRunner.Character
{
    [CreateAssetMenu(menuName = "ShapeRunner/Character/CharacterConfig")]
    public class CharacterConfig : ScriptableObject
    {
        [SerializeField]
        private Shape _shape;
        [SerializeField]
        private Sprite _sprite;

        public Shape Shape => _shape;
        public Sprite Sprite => _sprite;
        public IAccelerator Accelerator => ShapesAccelerators.Map[_shape]; 
    }
}