using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttacker
{
    float damage { get; }
    void Attack();
}
