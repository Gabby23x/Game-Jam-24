using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        if(Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(Vector2.right * Time.deltaTime * 1.8f);
        } else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * Time.deltaTime * 1.8f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * Time.deltaTime * 1.8f);
        }

    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("House"))
    //    {
    //        Debug.Log("House collided with Giant!");
    //        // Do something specific to the collision between house and giant
    //    }
    //}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("House collided with Giant!");
        if (collision.gameObject.name == "House")
        {
            Debug.Log("House collided with Giant!");
        }
    }
}
