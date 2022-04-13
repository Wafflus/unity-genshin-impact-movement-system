using UnityEngine;

namespace GenshinImpactMovementSystem
{
    public class ResizableCapsuleCollider : MonoBehaviour
    {
        public CapsuleColliderData CapsuleColliderData { get; private set; }
        [field: SerializeField] public DefaultColliderData DefaultColliderData { get; private set; }
        [field: SerializeField] public SlopeData SlopeData { get; private set; }

        private void Awake()
        {
            Resize();
        }

        private void OnValidate()
        {
            Resize();
        }

        public void Resize()
        {
            Initialize(gameObject);

            CalculateCapsuleColliderDimensions();
        }

        public void Initialize(GameObject gameObject)
        {
            if (CapsuleColliderData != null)
            {
                return;
            }

            CapsuleColliderData = new CapsuleColliderData();

            CapsuleColliderData.Initialize(gameObject);

            OnInitialize();
        }

        protected virtual void OnInitialize()
        {
        }

        public void CalculateCapsuleColliderDimensions()
        {
            SetCapsuleColliderRadius(DefaultColliderData.Radius);

            SetCapsuleColliderHeight(DefaultColliderData.Height * (1f - SlopeData.StepHeightPercentage));

            RecalculateCapsuleColliderCenter();

            RecalculateColliderRadius();

            CapsuleColliderData.UpdateColliderData();
        }

        public void SetCapsuleColliderRadius(float radius)
        {
            CapsuleColliderData.Collider.radius = radius;
        }

        public void SetCapsuleColliderHeight(float height)
        {
            CapsuleColliderData.Collider.height = height;
        }

        public void RecalculateCapsuleColliderCenter()
        {
            float colliderHeightDifference = DefaultColliderData.Height - CapsuleColliderData.Collider.height;

            Vector3 newColliderCenter = new Vector3(0f, DefaultColliderData.CenterY + (colliderHeightDifference / 2f), 0f);

            CapsuleColliderData.Collider.center = newColliderCenter;
        }

        public void RecalculateColliderRadius()
        {
            float halfColliderHeight = CapsuleColliderData.Collider.height / 2f;

            if (halfColliderHeight >= CapsuleColliderData.Collider.radius)
            {
                return;
            }

            SetCapsuleColliderRadius(halfColliderHeight);
        }
    }
}