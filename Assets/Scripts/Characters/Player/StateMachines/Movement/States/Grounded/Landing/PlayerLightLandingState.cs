using UnityEngine;

namespace GenshinImpactMovementSystem
{
    public class PlayerLightLandingState : PlayerLandingState
    {
        public PlayerLightLandingState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            stateMachine.ReusableData.MovementSpeedModifier = 0;

            stateMachine.ReusableData.CurrentJumpForce = airborneData.JumpData.StationaryForce;

            ResetVelocity();
        }

        public override void Update()
        {
            base.Update();

            if (stateMachine.ReusableData.MovementInput == Vector2.zero)
            {
                return;
            }

            OnMove();
        }

        public override void OnAnimationTransitionEvent()
        {
            stateMachine.ChangeState(stateMachine.IdlingState);
        }
    }
}