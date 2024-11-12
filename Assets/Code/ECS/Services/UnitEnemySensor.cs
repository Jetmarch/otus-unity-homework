using Leopotam.EcsLite.Entities;
using OtusHomework.ECS.Components;
using UnityEngine;

namespace OtusHomework.ECS.Services
{
    public class UnitEnemySensor : MonoBehaviour
    {
        [SerializeField] private Entity _owner;
        
        private void OnTriggerEnter(Collider other)
        {
            var entity = other.GetComponent<Entity>();
            if (entity == null) return;
            _owner.SetData(new Target() { Value = entity });
        }

        private void OnTriggerExit(Collider other)
        {
            var entity = other.GetComponent<Entity>();
            if (entity == null) return;
            _owner.RemoveData<Target>();
        }
    }
}