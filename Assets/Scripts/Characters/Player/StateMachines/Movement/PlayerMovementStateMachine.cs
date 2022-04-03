namespace GenshinImpactMovementSystem
{
    public class PlayerMovementStateMachine : StateMachine
    {
        public Player Player { get; }

        public PlayerIdlingState IdlingState { get; }

        public PlayerWalkingState WalkingState { get; }
        public PlayerRunningState RunningState { get; }
        public PlayerSprintingState SprintingState { get; }

        public PlayerMovementStateMachine(Player player)
        {
            Player = player;

            IdlingState = new PlayerIdlingState(this);

            WalkingState = new PlayerWalkingState(this);
            RunningState = new PlayerRunningState(this);
            SprintingState = new PlayerSprintingState(this);
        }
    }
}