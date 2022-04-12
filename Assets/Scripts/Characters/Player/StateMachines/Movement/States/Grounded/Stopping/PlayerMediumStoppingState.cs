namespace GenshinImpactMovementSystem
{
    public class PlayerMediumStoppingState : PlayerStoppingState
    {
        public PlayerMediumStoppingState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            stateMachine.ReusableData.MovementDecelerationForce = groundedData.StopData.MediumDecelerationForce;

            stateMachine.ReusableData.CurrentJumpForce = airborneData.JumpData.MediumForce;
        }
    }
}