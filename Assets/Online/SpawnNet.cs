using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Unity.Netcode;
public class SpawnNet : NetworkBehaviour
{
    public GameObject myPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IsOwner)
        {
            if (Input.GetKeyDown("space"))
            {
                GameObject go = Instantiate(myPrefab, transform.position + Vector3.down * 2, Quaternion.identity);
                go.GetComponent<NetworkObject>().Spawn();
            }
        }
    }
}
