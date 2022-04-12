namespace GenshinImpactMovementSystem
{
    public class PlayerAirborneState : PlayerMovementState
    {
        public PlayerAirborneState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
        }

        protected override void OnContactWithGround()
        {
            stateMachine.ChangeState(stateMachine.IdlingState);
        }
    }
}