using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWaveInfo
{
    public float GetSpawnInterval();
    public List<GroupInfo> GetGroupInfo();

}
