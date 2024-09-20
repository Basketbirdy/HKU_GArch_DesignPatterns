using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArcher : EnemyBase, IAttacker, IDamagable, IMover
{
    public float Damage { get; }

    public float Health { get; }

    public float Speed {  get; }

    public EnemyArcher()
    {
        Damage = 3;
        Health = 60;
        Speed = 4;
    }   

    public void Attack()
    {
        // Archer shot
    }

    public void Die()
    {
        // archer death
    }

    public void Move()
    {
        // archer move
    }
}

public class EnemyTower : EnemyBase, IAttacker, IDamagable
{
    public float Damage { get; }

    public float Health { get; }

    public EnemyTower()
    {
        Damage = 7;
        Health = 120;
    }

    public void Attack()
    {
        // tower attack
    }

    public void Die()
    {
        // tower die
    }
}

public class EnemySteelRam : EnemyBase, IAttacker, IMover
{
    public float Damage { get; }

    public float Speed { get; }

    public EnemySteelRam()
    {
        Damage = 10;
        Speed = 1;
    }

    public void Attack()
    {
        // steelram attack
    }

    public void Move()
    {
        //  steelram move
    }
}
