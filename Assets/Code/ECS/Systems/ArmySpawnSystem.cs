using Leopotam.EcsLite;
using Leopotam.EcsLite.Di;

namespace OtusHomework.ECS.Systems
{
    public class ArmySpawnSystem : IEcsInitSystem
    {
        private readonly EcsWorldInject _eventWorld = EcsWorlds.Events;
        
        public void Init(IEcsSystems systems)
        {
            throw new System.NotImplementedException();
        }
    }
}