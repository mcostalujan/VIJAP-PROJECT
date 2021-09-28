using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawnerController : MonoBehaviour
{
    [SerializeField] GameObject[] characterPrefab;
    [Range(1,10)][SerializeField] float spawnRate = 1;


    void Start()
    {
        StartCoroutine(SpawnNewCharacter());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnNewCharacter(){
        while(true){
            yield return new WaitForSeconds(3/spawnRate);
            float random = Random.Range(0.0f, 1.0f);
            if(random< GameManager.Instance.difficulty * 0.1f){
             Instantiate(characterPrefab[0]);
            }else{
             Instantiate(characterPrefab[1]);
            }
        }
    }
}
