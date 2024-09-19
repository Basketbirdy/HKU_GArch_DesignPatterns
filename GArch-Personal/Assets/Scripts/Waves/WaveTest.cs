using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class WaveTest : MonoBehaviour
{
    IWaveInfo waveInfo;
    List<ShapeInfo> shapes = new List<ShapeInfo>();

    private void Start()
    {
        Debug.Log("[Wave]----------------------------------------------- ");

        waveInfo = new WaveInfoBase();

        DebugWaveInfo();

        waveInfo = new ShapeWaveDecorator(waveInfo, new ShapeInfo(Shape.SQUARE));

        waveInfo = new ShapeWaveDecorator(waveInfo, new ShapeInfo(Shape.STAR));

        DebugWaveInfo();

        waveInfo = new SpawnIntervalWaveDecorator(waveInfo, -.2f);

        DebugWaveInfo();

        Debug.Log("----------------------------------------------------- ");
    }

    private void DebugWaveInfo()
    {
        Debug.Log("[Wave] SpawnInterval: ");
        Debug.Log("[Wave] " + waveInfo.GetSpawnInterval().ToString());

        shapes = waveInfo.GetShapeInfo();
        Debug.Log("[Wave] Spawn Shapes: ");
        if (shapes.Count == 0) { Debug.Log("[Wave] -"); }
        foreach (ShapeInfo shapeInfo in shapes)
        {
            Debug.Log("[Wave] Shape: " + shapeInfo.shape.ToString() + "; Direction: " + shapeInfo.direction.ToString());
        }
    }
}
