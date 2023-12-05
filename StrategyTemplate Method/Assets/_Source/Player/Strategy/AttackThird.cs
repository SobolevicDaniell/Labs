using UnityEngine;

namespace Player.Strategy
{
    public class AttackThird : IAttackStrategy
    {
        private readonly Animator _animator;
        private readonly int _attack3 = Animator.StringToHash("Attack3");

        public AttackThird(Animator animator)
        {
            _animator = animator;
        }

        public void StartAnimation()
        {
            _animator.SetTrigger(_attack3);
        }
    }
}
