using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] snacksPrefabs;
    public int snacksPrefabIndex;
    public GameObject spawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        snacksPrefabIndex = Random.Range(0,snacksPrefabs.Length);
        Instantiate(snacksPrefabs[snacksPrefabIndex], spawnLocation.transform.position + new Vector3(0,0,0), Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }
}
