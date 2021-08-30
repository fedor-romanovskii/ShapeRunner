using System;
using System.Collections;
using ShapeRunner.Game.Services;
using ShapeRunner.Settings;
using UnityEngine;

namespace ShapeRunner.Character
{
    public class Jumper : MonoBehaviour
    {
        [SerializeField]
        private AnimationCurve _trajectory;
        [SerializeField]
        private Transform _body;

        private Coroutine _jumpRoutine;
        private float _gravity;

        private float _lastKeyValueX => _trajectory.keys[_trajectory.length - 1].time;

        private void Awake()
        {
            var loadingData = ServiceContainer.Instance.GetSingle<LoadingData>();
            var worldConfig = loadingData.WorldConfig;
            _gravity = worldConfig.Gravity;
        }

        public void Jump()
        {
            if (_jumpRoutine != null) return;

            _jumpRoutine = StartCoroutine(JumpRoutine(OnFinish));
        }

        private IEnumerator JumpRoutine(Action onFinish)
        {
            var progress = 0f;
            var startPosition = _body.transform.position;
            while (progress <= _lastKeyValueX)
            {
                progress += Time.deltaTime * _gravity;
                var yOffset = Vector3.up * _trajectory.Evaluate(progress);
                _body.transform.position = startPosition + yOffset;
                yield return null;
            }
            onFinish?.Invoke();
        }

        private void OnFinish()
        {
            _jumpRoutine = null;
        }
    }
}