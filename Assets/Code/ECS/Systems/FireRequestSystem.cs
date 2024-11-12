using Leopotam.EcsLite;
using Leopotam.EcsLite.Di;
using OtusHomework.ECS.Components;
using UnityEngine;

namespace OtusHomework.ECS.Systems
{
    public sealed class FireRequestSystem : IEcsRunSystem
    {
        private readonly EcsFilterInject<Inc<BulletWeapon, FireRequest>, Exc<ShootDelay>> _filter;
        
        private readonly EcsPoolInject<ShootDelay> _shootDelayPool;
        
        private readonly EcsWorldInject _eventWorld = EcsWorlds.Events;
        private readonly EcsPoolInject<SpawnRequest> _spawnRequestPool = EcsWorlds.Events;
        private readonly EcsPoolInject<Position> _positionPool = EcsWorlds.Events;
        private readonly EcsPoolInject<Rotation> _rotationPool = EcsWorlds.Events;
        private readonly EcsPoolInject<Prefab> _prefabPool = EcsWorlds.Events;
        
        public void Run(IEcsSystems systems)
        {
            var bulletWeaponPool = _filter.Pools.Inc1;
            var fireRequestPool = _filter.Pools.Inc2;

            foreach (var entity in _filter.Value)
            {
                var bulletWeapon = bulletWeaponPool.Get(entity);
                fireRequestPool.Del(entity);
                _shootDelayPool.Value.Add(entity) = new ShootDelay() { Value = bulletWeapon.FireRate };

                var newEntity = _eventWorld.Value.NewEntity();
                _spawnRequestPool.Value.Add(newEntity);
                _prefabPool.Value.Add(newEntity) = new Prefab() { Value = bulletWeapon.BulletPrefab };
                _positionPool.Value.Add(newEntity) = new Position() { Value = bulletWeapon.FirePoint.position };
                _rotationPool.Value.Add(newEntity) = new Rotation() { Value = bulletWeapon.FirePoint.rotation };

            }
        }
    }
}