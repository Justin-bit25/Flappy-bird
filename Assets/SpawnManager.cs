using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipePrefab;
    float randomHeight = 0.5f;
    void Start()
    {
        InvokeRepeating("SpawnPipes", 1.0f, 1.0f);
    }
void SpawnPipes()
{
    Instantiate(pipePrefab, new Vector3(6.75f,Random.Range(-1.9f, 2.5f)), Quaternion.identity);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
