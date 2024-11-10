using Leopotam.EcsLite.Entities;
using OtusHomework.ECS.Components;
using UnityEngine;

namespace OtusHomework.ECS.Installers
{
    public class BulletInstaller : EntityInstaller
    {
        [SerializeField] private float _moveSpeed = 5.0f;
        
        protected override void Install(Entity entity)
        {
            entity.AddData(new Position { Value = transform.position });
            entity.AddData(new Rotation { Value = transform.rotation });
            entity.AddData(new MoveDirection { Value = Vector3.forward });
            entity.AddData(new MoveSpeed { Value = _moveSpeed });
            entity.AddData(new TransformView { Value = transform });
        }

        protected override void Dispose(Entity entity)
        {
        }
    }
}