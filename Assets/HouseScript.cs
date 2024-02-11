using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("House collided with Giant!");
        if (other.CompareTag("Giant"))
        {
            Debug.Log("House collided with Giant!");
            // Do something specific to the collision between house and giant
        }
    }
}
