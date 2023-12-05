using System;
using Player;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private AttackPerformer attackPerformer;
        [SerializeField] private Listener listener;
        [SerializeField] private Animator animator;

        private Character _character;
        
        private void Awake()
        {
            _character = new Character(animator);
            attackPerformer.VariantAttack += _character.SetStrategy;
            listener.OnButtonPress += _character.PerformAttack;
        }
    }
}