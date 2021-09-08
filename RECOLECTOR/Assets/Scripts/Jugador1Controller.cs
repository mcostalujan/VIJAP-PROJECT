using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador1Controller : MonoBehaviour
{
    private InputCharacter inputJugador;
    private Transform transformxd;
    [SerializeField] private float velocidad = 3;
    private float h, v;

    private Rigidbody2D cuerpo1;

    void Start()
    {
        inputJugador = GetComponent<InputCharacter>();
        transformxd = GetComponent<Transform>();
        cuerpo1 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        h = inputJugador.ejeH;
        v = inputJugador.ejeV;

        //Vector2 pos = transformxd.position +
        //    new Vector3(
        //        velocidad * h * Time.deltaTime,
        //        velocidad * v * Time.deltaTime, 0
        //    );
        //transformxd.position = pos;
        Vector2 pos = new Vector2(h, v) * velocidad;
        cuerpo1.velocity = pos;
    }
}
