using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.VersionControl.Asset;

public class WaveHandler : MonoBehaviour
{
    [SerializeField] IWaveInfo[] possibleWaveInfos;

    [SerializeField] Wave currentWave;

    private void Start()
    {
        currentWave = GenerateWave();

        DebugWaveInfo(currentWave);
    }

    private Wave GenerateWave()
    {
        Wave newWave = new Wave();
        return newWave;
    }

    private void DebugWaveInfo(Wave wave)
    {
        Debug.Log("[Wave] SpawnInterval: ");
        Debug.Log("[Wave] " + wave.waveInfo.GetSpawnInterval().ToString());

        List<ShapeInfo> shapes = wave.waveInfo.GetShapeInfo();
        Debug.Log("[Wave] Spawn Shapes: ");
        if (shapes.Count == 0) { Debug.Log("[Wave] -"); }
        foreach (ShapeInfo shapeInfo in shapes)
        {
            Debug.Log("[Wave] Shape: " + shapeInfo.shape.ToString() + "; Direction: " + shapeInfo.direction.ToString());
        }
    }
}
