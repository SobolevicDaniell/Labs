using System.Collections.Generic;
using Enemy.ProjectileLogic;
using UnityEngine;

namespace Enemy
{
    public class Enemy2 : EnemyBase
    {
        [SerializeField] private int countProjectile;
        [SerializeField] private GameObject prefabProjectile;
        [SerializeField] private ShootPoint shoot;
        
        private void Start()
        {
            ObjectPool objectPool = new ObjectPool(prefabProjectile, transform);
            objectPool.CreateObject(countProjectile);
            shoot.SetObjectPool(objectPool);
        }
        
        public override void Update() { }
    }
}