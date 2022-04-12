using UnityEngine;

namespace GenshinImpactMovementSystem
{
    public class PlayerFallingState : PlayerAirborneState
    {
        public PlayerFallingState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            stateMachine.ReusableData.MovementSpeedModifier = 0f;

            ResetVerticalVelocity();
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();

            LimitVerticalVelocity();
        }

        private void LimitVerticalVelocity()
        {
            Vector3 playerVerticalVelocity = GetPlayerVerticalVelocity();

            if (playerVerticalVelocity.y >= -airborneData.FallData.FallSpeedLimit)
            {
                return;
            }

            Vector3 limitedVelocityForce = new Vector3(0f, -airborneData.FallData.FallSpeedLimit - playerVerticalVelocity.y, 0f);

            stateMachine.Player.Rigidbody.AddForce(limitedVelocityForce, ForceMode.VelocityChange);
        }

        protected override void ResetSprintState()
        {
        }
    }
}