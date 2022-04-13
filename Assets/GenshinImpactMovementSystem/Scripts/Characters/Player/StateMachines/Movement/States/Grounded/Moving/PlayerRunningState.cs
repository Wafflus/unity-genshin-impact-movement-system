using UnityEngine;
using UnityEngine.InputSystem;

namespace GenshinImpactMovementSystem
{
    public class PlayerRunningState : PlayerMovingState
    {
        private float startTime;

        public PlayerRunningState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
        }

        public override void Enter()
        {
            stateMachine.ReusableData.MovementSpeedModifier = groundedData.RunData.SpeedModifier;

            base.Enter();

            StartAnimation(stateMachine.Player.AnimationData.RunParameterHash);

            stateMachine.ReusableData.CurrentJumpForce = airborneData.JumpData.MediumForce;

            startTime = Time.time;
        }

        public override void Exit()
        {
            base.Exit();

            StopAnimation(stateMachine.Player.AnimationData.RunParameterHash);
        }

        public override void Update()
        {
            base.Update();

            if (!stateMachine.ReusableData.ShouldWalk)
            {
                return;
            }

            if (Time.time < startTime + groundedData.SprintData.RunToWalkTime)
            {
                return;
            }

            StopRunning();
        }

        private void StopRunning()
        {
            if (stateMachine.ReusableData.MovementInput == Vector2.zero)
            {
                stateMachine.ChangeState(stateMachine.IdlingState);

                return;
            }

            stateMachine.ChangeState(stateMachine.WalkingState);
        }

        protected override void OnWalkToggleStarted(InputAction.CallbackContext context)
        {
            base.OnWalkToggleStarted(context);

            stateMachine.ChangeState(stateMachine.WalkingState);
        }

        protected override void OnMovementCanceled(InputAction.CallbackContext context)
        {
            stateMachine.ChangeState(stateMachine.MediumStoppingState);

            base.OnMovementCanceled(context);
        }
    }
}