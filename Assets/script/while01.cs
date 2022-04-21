using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class while01 : MonoBehaviour
{
    public int encounter = 1, encounterMax = 100;
    // Start is called before the first frame update
    void Start()
    {
        while (encounter < encounterMax){
            Debug.Log("Este mensaje se repetira,esta en la vuelta numero " + encounter);
            encounter++;
        }
        Debug.Log("Se termino el while");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
