using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttacker
{
    float Damage { get; }
    void Attack();
}
