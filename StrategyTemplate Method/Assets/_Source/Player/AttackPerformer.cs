using System;
using UnityEngine;
using UnityEngine.UI;

namespace Player
{
    public class AttackPerformer : MonoBehaviour
    {
        public event Action<int> VariantAttack;

        [SerializeField] private Button button1;
        [SerializeField] private Button button2;
        [SerializeField] private Button button3;

        private void OnEnable()
        {
            button1.onClick.AddListener(Clear);
            button2.onClick.AddListener(Clear);
            button3.onClick.AddListener(Clear);
            
            button1.onClick.AddListener(FirstVariantAttack);
            button2.onClick.AddListener(SecondVariantAttack);
            button3.onClick.AddListener(ThirdVariantAttack);
        }

        private void OnDisable()
        {
            button1.onClick.RemoveAllListeners();
            button2.onClick.RemoveAllListeners();
            button3.onClick.RemoveAllListeners();
        }

        private void FirstVariantAttack()
        {
            button1.image.color = Color.green;
            button1.interactable = false;
            VariantAttack?.Invoke(1);
        }

        private void SecondVariantAttack()
        {
            button2.image.color = Color.green;
            button2.interactable = false;
            VariantAttack?.Invoke(2);
        }

        private void ThirdVariantAttack()
        {
            button3.image.color = Color.green;
            button3.interactable = false;
            VariantAttack?.Invoke(3);
        }

        private void Clear()
        {
            button1.image.color = Color.white;
            button2.image.color = Color.white;
            button3.image.color = Color.white;
            
            button1.interactable = true;
            button2.interactable = true;
            button3.interactable = true;
        }
    }
}
