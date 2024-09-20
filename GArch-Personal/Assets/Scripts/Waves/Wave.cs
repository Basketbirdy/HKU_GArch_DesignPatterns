using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Wave
{
    //public List<EnemyBase> enemies;
    public IWaveInfo waveInfo;

    private int maxDecoratorCount = 5;
    private Vector2 intervalRange = new Vector2(-.4f, .4f);
    private List<Type> possibleDecorators = new List<Type>();

    public Wave()
    {
        //generate list of all possible decorators
        possibleDecorators = new List<Type>()
        {
            typeof(SpawnIntervalWaveDecorator),
            typeof(ShapeWaveDecorator)
        };
        waveInfo = GenerateWaveInfo();
    }

    private IWaveInfo GenerateWaveInfo()
    {
        IWaveInfo newWaveInfo = new WaveInfoBase();

        //determine what decorators to put on the wave
        //generate number of decorators
        int randDecoratorCount = UnityEngine.Random.Range(0, maxDecoratorCount);
        //for number of decorators
        for (int i = 0; i < randDecoratorCount; i++)
        {
            // add random decorator from possible decorators
            int rand = UnityEngine.Random.Range(0, possibleDecorators.Count);
            newWaveInfo = (IWaveInfo)Activator.CreateInstance(possibleDecorators[rand], newWaveInfo);
            Debug.Log("[Wave] Applying decorator" + possibleDecorators[rand].ToString());
        }

        return newWaveInfo;
    }
}
   
