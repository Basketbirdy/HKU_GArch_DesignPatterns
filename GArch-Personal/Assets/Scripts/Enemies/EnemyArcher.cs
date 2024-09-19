using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArcher : EnemyBase, IAttacker, IDamagable, IMover
{

    public float damage { get; }

    public float health { get; }

    public float speed {  get; }

    public EnemyArcher(float damage, float health, float speed)
    {
        this.damage = damage;
        this.health = health;
        this.speed = speed;
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

    public EnemyTower(float damage, float health)
    {
        this.damage = damage;
        this.health = health;
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

public class SteelRamEnemy : EnemyBase, IAttacker, IMover
{
    public float damage { get; }

    public float speed { get; }

    public void Attack()
    {
        // steelram attack
    }

    public void Move()
    {
        //  steelram move
    }
}
