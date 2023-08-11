using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Unity.Netcode;
public class ResourceSpawnned : NetworkBehaviour
{
 
    public override void OnNetworkSpawn()
    {
    }

    public override void OnNetworkDespawn()
    {
        base.OnNetworkDespawn();
    }
}

