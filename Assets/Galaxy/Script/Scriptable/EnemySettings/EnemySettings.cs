using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemySettings", menuName = "ScriptableObjects/Create EnemySettings")]
public class EnemySettings : ScriptableObject
{
    //体力
    [SerializeField]
    int hp;
    //攻撃力
    [SerializeField]
    int power;
    //歩く速度
    [SerializeField]
    float walkSpeed;

    public int Hp { get => hp; }
    public int Power { get => power; }
    public float WalkSpeed { get => walkSpeed; }
}
