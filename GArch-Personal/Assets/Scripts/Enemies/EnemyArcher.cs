using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArcher : EnemyBase, IAttacker, IDamagable, IMover
{
    public float damage { get; }

    public float health { get; }

    public float speed {  get; }

    public EnemyArcher()
    {
        this.damage = 3;
        this.health = 60;
        this.speed = 4;
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
    public float damage { get; }

    public float health { get; }

    public EnemyTower()
    {
        this.damage = 7;
        this.health = 120;
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
    public float damage { get; }

    public float speed { get; }

    public EnemySteelRam()
    {
        damage = 10;
        speed = 1;
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
