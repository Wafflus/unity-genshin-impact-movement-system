using System;
using UnityEngine;

namespace GenshinImpactMovementSystem
{
    [Serializable]
    public class PlayerRunData
    {
        [field: SerializeField] [field: Range(0f, 1f)] public float SpeedModifier { get; private set; }
    }
}