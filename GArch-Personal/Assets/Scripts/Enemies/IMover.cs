using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMover
{
    float speed { get; }
    void Move();
}
