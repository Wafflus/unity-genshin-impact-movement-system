using UnityEngine.InputSystem;

namespace GenshinImpactMovementSystem
{
    public class PlayerRunningState : PlayerMovingState
    {
        private readonly PlayerRunData runData;

        public PlayerRunningState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
            runData = groundedData.RunData;
        }

        public override void Enter()
        {
            base.Enter();

            stateMachine.ReusableData.MovementSpeedModifier = runData.SpeedModifier;
        }

        protected override void OnWalkToggleStarted(InputAction.CallbackContext context)
        {
            base.OnWalkToggleStarted(context);

            stateMachine.ChangeState(stateMachine.WalkingState);
        }
    }
}