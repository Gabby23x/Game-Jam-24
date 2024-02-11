using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null){
            transform.position = new Vector3(player.position.x+5.5f, player.position.y+1.5f, transform.position.z);
        }
    }
}
