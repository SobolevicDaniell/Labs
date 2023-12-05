using System.Collections;
using UnityEngine;

namespace Enemy.ProjectileLogic
{
    public class Projectile : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rigidbody2D;
        [SerializeField] private int delay;
        [SerializeField] private float x;
        
        void OnEnable()
        {
            rigidbody2D.AddForce(new Vector2(x, 0), ForceMode2D.Impulse);
            StartCoroutine(DeactivateRoutine());
        }
        
        IEnumerator DeactivateRoutine()
        {
            yield return new WaitForSeconds(delay);

            rigidbody2D.velocity = new Vector3(0f, 0f, 0f);
            gameObject.SetActive(false);
        }
    }
}
