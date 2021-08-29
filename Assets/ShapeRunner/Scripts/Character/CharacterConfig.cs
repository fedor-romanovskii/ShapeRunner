using ShapeRunner.Accelerator;
using UnityEngine;

namespace ShapeRunner.Character
{
    [CreateAssetMenu(menuName = "ShapeRunner/Character/CharacterConfig")]
    public class CharacterConfig : ScriptableObject
    {
        [SerializeField]
        private Shape _shape;

        public Shape Shape => _shape;
        public IAccelerator Accelerator => ShapesAccelerators.Map[_shape]; 
    }
}