using Player.Strategy;
using UnityEngine;

namespace Player
{
    public class Character
    {
        private readonly AttackFirst _attackFirst;
        private readonly AttackSecond _attackSecond;
        private readonly AttackThird _attackThird;
        
        private int _variantAttack;

        public Character(Animator animator)
        {
            _attackFirst = new AttackFirst(animator);
            _attackSecond = new AttackSecond(animator);
            _attackThird = new AttackThird(animator);
        }

        public void SetStrategy(int variant) => _variantAttack = variant;

        public void PerformAttack()
        {
            if (_variantAttack == 1)
            { 
                _attackFirst.StartAnimation();
            }
            else if (_variantAttack == 2)
            {
                _attackSecond.StartAnimation();
            }
            else if (_variantAttack == 3)
            {
                _attackThird.StartAnimation();
            }
        }
    }
}
