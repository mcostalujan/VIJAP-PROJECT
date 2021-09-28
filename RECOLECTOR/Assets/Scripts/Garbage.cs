using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garbage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] characterPoints = GameObject.FindGameObjectsWithTag("Character");
        int randomSpawnPoint = Random.Range(0, characterPoints.Length);
        if(characterPoints[randomSpawnPoint]){
            transform.position = characterPoints[randomSpawnPoint].transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
