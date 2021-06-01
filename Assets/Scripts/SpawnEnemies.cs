using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject prefab;

    public GameObject leftSpawn;
    public GameObject rightSpawn;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            if (Random.Range(0, 2) == 0)
                GameObject.Instantiate(prefab, leftSpawn.transform);
            else
                GameObject.Instantiate(prefab, rightSpawn.transform);
        
            yield return new WaitForSeconds(2f);
        }
    }
}
