using UnityEngine;

namespace GenshinImpactMovementSystem
{
    public class PlayerIdlingState : PlayerGroundedState
    {
        public PlayerIdlingState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();

            speedModifier = 0f;

            ResetVelocity();
        }

        public override void Update()
        {
            base.Update();

            if (movementInput == Vector2.zero)
            {
                return;
            }

            OnMove();
        }

        private void OnMove()
        {
            if (shouldWalk)
            {
                stateMachine.ChangeState(stateMachine.WalkingState);

                return;
            }

            stateMachine.ChangeState(stateMachine.RunningState);
        }
    }
}