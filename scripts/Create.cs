using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //criando um cubo na posi��o 0,0,0 (no in�cio)
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
