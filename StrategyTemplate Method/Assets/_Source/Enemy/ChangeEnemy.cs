using UnityEngine;
using UnityEngine.UI;

namespace Enemy
{
    public class ChangeEnemy : MonoBehaviour
    {
        [SerializeField] private GameObject enemy1;
        [SerializeField] private GameObject enemy2;
        [SerializeField] private GameObject enemy3;
        [SerializeField] private Button button1;
        [SerializeField] private Button button2;
        [SerializeField] private Button button3;
        
        void OnEnable()
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
            enemy1.SetActive(true);
        }

        private void SecondVariantAttack()
        {
            enemy2.SetActive(true);
        }

        private void ThirdVariantAttack()
        {
            enemy3.SetActive(true);
        }

        private void Clear()
        {
            enemy1.SetActive(false);
            enemy2.SetActive(false);
            enemy3.SetActive(false);
        }
    }
}
