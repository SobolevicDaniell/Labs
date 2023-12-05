using UnityEngine;

namespace Player.Strategy
{
    public class AttackFirst : IAttackStrategy
    {
        private readonly Animator _animator;
        private readonly int _attack1 = Animator.StringToHash("Attack1");
        
        public AttackFirst(Animator animator)
        {
            _animator = animator;
        }

        public void StartAnimation()
        {
            _animator.SetTrigger(_attack1);
        }
    }
}
