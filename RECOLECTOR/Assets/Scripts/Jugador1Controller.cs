using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador1Controller : MonoBehaviour
{
    // Move
    private InputCharacter inputJugador;
    private float h, v;
    UnityEngine.Vector3 moveDirection;
    [SerializeField] private float speed = 3;
    [SerializeField] private float speedRotation = 720;
    private bool isFacingRight = true;

    [SerializeField] Animator anim;

    void Start()
    {
        inputJugador = GetComponent<InputCharacter>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMove();
        // Debug.Log(transform.position.x);
        if(moveDirection.x != 0){
            anim.enabled = true;
        }else{
            anim.enabled = false;
        }

    }
    private void UpdateMove(){
        h = inputJugador.ejeH;
        v = inputJugador.ejeV;
        // Debug.Log(h);


        moveDirection.x=h;
        moveDirection.y=v;

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
