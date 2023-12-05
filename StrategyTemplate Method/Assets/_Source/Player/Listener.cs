using System;
using UnityEngine;

namespace Player
{
    public class Listener : MonoBehaviour
    {
        public event Action OnButtonPress;

        [SerializeField] private KeyCode button;
        
        private void Update()
        {
            if (Input.GetKeyDown(button))
            {
                OnButtonPress?.Invoke();
            }
        }
    }
}