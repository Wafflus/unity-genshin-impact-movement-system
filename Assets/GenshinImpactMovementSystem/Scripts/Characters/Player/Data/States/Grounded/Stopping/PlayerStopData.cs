using System;
using UnityEngine;

namespace GenshinImpactMovementSystem
{
    [Serializable]
    public class PlayerStopData
    {
        [field: SerializeField] [field: Range(0f, 15f)] public float LightDecelerationForce { get; private set; } = 5f;
        [field: SerializeField] [field: Range(0f, 15f)] public float MediumDecelerationForce { get; private set; } = 6.5f;
        [field: SerializeField] [field: Range(0f, 15f)] public float HardDecelerationForce { get; private set; } = 5f;
    }
}