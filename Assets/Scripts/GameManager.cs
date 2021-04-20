using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

namespace Botland
{
    public class GameManagerData : IComponentData
    {
        public Transform Transform;
    }

    public class GameManager : MonoBehaviour, IConvertGameObjectToEntity
    {
        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            dstManager.AddComponentData(entity, new GameManagerData
            {
                Transform = transform
            });
        }

        // Start is called before the first frame update
        private void Start()
        {

        }

        // Update is called once per frame
        private void Update()
        {

        }
    }
}