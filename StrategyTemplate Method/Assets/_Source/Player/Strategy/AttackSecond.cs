using UnityEngine;

namespace Player.Strategy
{
    public class AttackSecond : IAttackStrategy
    {
        private readonly Animator _animator;
        private readonly int _attack2 = Animator.StringToHash("Attack2");

        public AttackSecond(Animator animator)
        {
            _animator = animator;
        }

        public void StartAnimation()
        {
            _animator.SetTrigger(_attack2);
        }
    }
}
