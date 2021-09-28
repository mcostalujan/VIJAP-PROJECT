using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] garbagePrefab;
    [Range(1,10)][SerializeField] float spawnRate = 1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnNewGarbage());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnNewGarbage(){
        while(true){
            yield return new WaitForSeconds(3/spawnRate);
            float random = Random.Range(0.0f, 1.0f);
            if(random< GameManager.Instance.difficulty * 0.1f){
             Instantiate(garbagePrefab[0]);
            }else{
             Instantiate(garbagePrefab[1]);
            }
        }
    }
}
