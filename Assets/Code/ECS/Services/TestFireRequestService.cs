using Leopotam.EcsLite.Entities;
using OtusHomework.ECS.Components;
using UnityEngine;

namespace OtusHomework.ECS.Services
{
    public class TestFireRequestService : MonoBehaviour
    {
        [SerializeField] private Entity _character;
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _character.SetData(new FireRequest());
            }
        }
    }
}