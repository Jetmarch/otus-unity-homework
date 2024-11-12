using System;
using System.Collections.Generic;
using Leopotam.EcsLite.Entities;
using UnityEngine;
// ReSharper disable InconsistentNaming

namespace OtusHomework.ECS.Components
{
    [Serializable]
    public struct Position
    {
        public Vector3 Value;
    }
    
    [Serializable]
    public struct Rotation
    {
        public Quaternion Value;
    }

    [Serializable]
    public struct MoveDirection
    {
        public Vector3 Value;
    }

    [Serializable]
    public struct MoveSpeed
    {
        public float Value;
    }

    [Serializable]
    public struct TransformView
    {
        public Transform Value;
    }

    [Serializable]
    public struct BulletWeapon
    {
        public Transform FirePoint;
        public Entity BulletPrefab;
        public float FireRate;
    }
    
    [Serializable]
    public struct FireRequest
    {
    }
    
    [Serializable]
    public struct Prefab
    {
        public Entity Value;
    }
    
    [Serializable]
    public struct SpawnRequest
    {
    }

    [Serializable]
    public struct Health
    {
        public float Value;
    }

    [Serializable]
    public struct DamageRequest
    {
        public float Value;
    }

    [Serializable]
    public struct DeathFlag
    {
    }

    [Serializable]
    public struct AttackDistance
    {
        public float Value;
    }

    [Serializable]
    public struct Target
    {
        public Entity Value;
    }

    [Serializable]
    public struct ShootDelay
    {
        public float Value;
    }

    [Serializable]
    public struct TimeToLive
    {
        public float Value;
    }

    [Serializable]
    public struct Unit
    {
        public UnitTeam Team;
    }
}