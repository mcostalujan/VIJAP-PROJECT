using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] float speed = 2;
    private bool isFacingRight = true;
    UnityEngine.Vector3 moveDirection;
    [SerializeField] Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        int randomSpawnPoint = Random.Range(0, spawnPoints.Length);
        transform.position = spawnPoints[randomSpawnPoint].transform.position;
        if(transform.position.x>0){
            moveDirection.x=-1;
        }else{
            moveDirection.x=1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMove();
        if(moveDirection.x != 0){
            anim.enabled = true;
        }else{
            anim.enabled = false;
        }
        if(transform.position.x>=9 || transform.position.x<=-9){
            Destroy(gameObject);
        }
        
    }
    private void UpdateMove(){

        
        moveDirection.y=0;

        transform.position += moveDirection * Time.deltaTime * speed;


        if(moveDirection.x < 0 && isFacingRight){
            Flip();
        }
        if(moveDirection.x > 0 && !isFacingRight){
            Flip();
        }
    }
    private void Flip(){
        if(isFacingRight){
            transform.position += new UnityEngine.Vector3(-0.5f,0,0);
        }else{
            transform.position += new UnityEngine.Vector3(0.5f,0,0);
        }
        transform.Rotate(0.0f,180.0f,0);
        isFacingRight = !isFacingRight;
    }
}
