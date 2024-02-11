using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseScript : MonoBehaviour
{
    public GameController logic;
    void Start(){
        logic = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("House collided with Giant!");
        logic.addScore(30);
        if (other.CompareTag("Giant"))
        {
            logic.addScore(30);
            Debug.Log("House collided with Giantssssssssssss!");
            // Do something specific to the collision between house and giant
        }
    }
}
