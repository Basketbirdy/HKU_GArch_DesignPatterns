using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWaveInfo
{
    float GetSpawnInterval();
    List<ShapeInfo> GetShapeInfo();

}
