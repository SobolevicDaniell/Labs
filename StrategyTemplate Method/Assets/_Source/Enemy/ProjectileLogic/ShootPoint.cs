using System.Collections.Generic;
using UnityEngine;

namespace Enemy.ProjectileLogic
{
    public class ShootPoint : MonoBehaviour
    {
        private ObjectPool _objectPool;

        private void TeleportBullet()
        {
            GameObject gameObject = _objectPool.GetObject();
            gameObject.transform.position = transform.position;
            gameObject.SetActive(true);
        }
        
        private void OnEnable()
        {
            TeleportBullet();
        }

        public void SetObjectPool(ObjectPool objectPool)
        {
            _objectPool = objectPool;
        }
    }
}
