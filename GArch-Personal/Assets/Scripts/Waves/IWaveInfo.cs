using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWaveInfo
{
    List<ShapeInfo> GetShapeInfo();
    float GetSpawnInterval();

}
