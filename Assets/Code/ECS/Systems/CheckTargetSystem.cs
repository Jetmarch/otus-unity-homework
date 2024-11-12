using Leopotam.EcsLite;
using Leopotam.EcsLite.Di;
using OtusHomework.ECS.Components;
using UnityEngine;

namespace OtusHomework.ECS.Systems
{
    public class CheckTargetSystem : IEcsRunSystem
    {
        private readonly EcsFilterInject<Inc<Target>> _filter;
        
        public void Run(IEcsSystems systems)
        {
            var targetPool = _filter.Pools.Inc1;

            foreach (var entity in _filter.Value)
            {
                var target = targetPool.Get(entity);
                
                if (!target.Value.IsAlive())
                {
                    Debug.Log(target.Value.gameObject.name + " is dead");
                    targetPool.Del(entity);
                }
            }
        }
    }
}