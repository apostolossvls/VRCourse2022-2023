using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        string otherName = collision.gameObject.name;
        Debug.Log(otherName);

        if (collision.gameObject.tag == "Player")
        {
            print("Hit player");
        }
        //print(otherName);
    }
}
