using System;
using UnityEngine;

namespace GenshinImpactMovementSystem
{
    [Serializable]
    public class DefaultColliderData
    {
        [field: Tooltip("The height is known through the Model Mesh Renderer \"bounds.size\" variable.")]
        [field: SerializeField] public float Height { get; private set; } = 1.8f;
        [field: SerializeField] public float CenterY { get; private set; } = 0.9f;
        [field: SerializeField] public float Radius { get; private set; } = 0.2f;
    }
}