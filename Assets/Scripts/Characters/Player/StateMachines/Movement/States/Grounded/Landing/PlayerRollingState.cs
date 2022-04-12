using UnityEngine;
using UnityEngine.InputSystem;

namespace GenshinImpactMovementSystem
{
    public class PlayerRollingState : PlayerLandingState
    {
        public PlayerRollingState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            stateMachine.ReusableData.MovementSpeedModifier = groundedData.RollData.SpeedModifier;

            stateMachine.ReusableData.ShouldSprint = false;
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();

            if (stateMachine.ReusableData.MovementInput != Vector2.zero)
            {
                return;
            }

            RotateTowardsTargetRotation();
        }

        public override void OnAnimationTransitionEvent()
        {
            if (stateMachine.ReusableData.MovementInput == Vector2.zero)
            {
                stateMachine.ChangeState(stateMachine.MediumStoppingState);

                return;
            }

            OnMove();
        }

        protected override void OnJumpStarted(InputAction.CallbackContext context)
        {
        }
    }
}