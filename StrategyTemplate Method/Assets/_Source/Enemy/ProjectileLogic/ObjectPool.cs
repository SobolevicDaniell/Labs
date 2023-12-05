using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy.ProjectileLogic
{
    public class ObjectPool
    {
        private GameObject _prefab;
        private Transform _parant;
        private List<GameObject> _objects = new();

        public ObjectPool(GameObject prefab, Transform parant)
        {
            _prefab = prefab;
            _parant = parant;
        }

        private GameObject CreateObject()
        {
            GameObject gameObcjet = Object.Instantiate(_prefab, _parant);
            _objects.Add(gameObcjet);
            return gameObcjet;
        }

        public void CreateObject(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _objects.Add(Object.Instantiate(_prefab, _parant));
            }
        }

        public GameObject GetObject()
        {
            for (int i = 0; i < _objects.Count; i++)
            {
                if (!_objects[i].activeSelf)
                {
                    return _objects[i];
                }
            }

            return CreateObject();
        }
    }
}
