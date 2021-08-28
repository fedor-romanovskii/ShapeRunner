using System;
using ShapeRunner.Game.Services;

namespace ShapeRunner.Input
{
    public interface IInput : IService
    {
        event Action Jump;
    }
}
