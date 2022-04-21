using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class while02 : MonoBehaviour
{
    public int num1, num2;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 < num2) {
            while (num1 < num2)
            {
                num1++;
            }   Debug.Log(num1);         
        }
        else if (num2 < num1)
        {
            while (num2 < num1)
            {
                num2++;
                Debug.Log(num2);
            }
            
        }
        else 
        {
            Debug.Log("Los numeros ingresados son iguales");
        }
    }
}

  
