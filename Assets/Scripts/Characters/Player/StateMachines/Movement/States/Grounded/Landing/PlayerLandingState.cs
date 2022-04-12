using UnityEngine.InputSystem;

namespace GenshinImpactMovementSystem
{
    public class PlayerLandingState : PlayerGroundedState
    {
        public PlayerLandingState(PlayerMovementStateMachine playerMovementStateMachine) : base(playerMovementStateMachine)
        {
        }

        protected override void OnMovementCanceled(InputAction.CallbackContext context)
        {
        }
    }
}