using Leopotam.EcsLite.Entities;
using OtusHomework.ECS.Components;
using UnityEngine;

namespace OtusHomework.ECS.Services
{
    public class DamageOnCollisionService : MonoBehaviour
    {
        [SerializeField] private float _damage;
        
        private void OnTriggerEnter(Collider other)
        {
            var entity = other.GetComponent<Entity>();
            if (entity == null) return;
            
            entity.AddData(new DamageRequest() { Value = _damage });
        }
    }
}