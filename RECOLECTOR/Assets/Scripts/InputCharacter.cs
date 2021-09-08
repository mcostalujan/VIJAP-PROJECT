using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCharacter : MonoBehaviour
{
    public float ejeH, ejeV;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        ejeH = Input.GetAxis("Horizontal");
        ejeV = Input.GetAxis("Vertical");
    }
}
