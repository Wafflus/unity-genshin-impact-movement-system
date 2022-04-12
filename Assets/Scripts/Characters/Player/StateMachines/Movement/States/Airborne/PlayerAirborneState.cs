using UnityEngine;

namespace GenshinImpactMovementSystem
{
    public class PlayerAirborneState : PlayerMovementState
    {
        public PlayerAirborneState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            StartAnimation(stateMachine.Player.AnimationData.AirborneParameterHash);

            ResetSprintState();
        }

        public override void Exit()
        {
            base.Exit();

            StopAnimation(stateMachine.Player.AnimationData.AirborneParameterHash);
        }

        protected virtual void ResetSprintState()
        {
            stateMachine.ReusableData.ShouldSprint = false;
        }

        protected override void OnContactWithGround(Collider collider)
        {
            stateMachine.ChangeState(stateMachine.LightLandingState);
        }
    }
}