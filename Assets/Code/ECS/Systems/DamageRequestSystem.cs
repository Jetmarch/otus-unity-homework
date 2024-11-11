using Leopotam.EcsLite;
using Leopotam.EcsLite.Di;
using OtusHomework.ECS.Components;

namespace OtusHomework.ECS.Systems
{
    public sealed class DamageRequestSystem : IEcsRunSystem
    {
        private readonly EcsFilterInject<Inc<Health, DamageRequest>> _filter;
        
        private readonly EcsPoolInject<DeathFlag> _deathFlagPool;
        
        public void Run(IEcsSystems systems)
        {
            var healthPool = _filter.Pools.Inc1;
            var damageRequestPool = _filter.Pools.Inc2;
            
            foreach (var entity in _filter.Value)
            {
                ref var health = ref healthPool.Get(entity);
                var damageRequest = damageRequestPool.Get(entity);
                
                health.Value -= damageRequest.Value;

                if (health.Value <= 0)
                {
                    _deathFlagPool.Value.Add(entity);
                }
                
                damageRequestPool.Del(entity);
            }
        }
    }
}