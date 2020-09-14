using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class crowd : MonoBehaviour
{

    private Rigidbody rigidBody;
    Vector3 movement;
    Vector3 initPos;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        initPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        movement = new Vector3(0f, 0f, -30f);
        rigidBody.velocity = movement;
    }

    void OnTriggerEnger(Collider other)
    {
        if (other.tag == "goal")
        {
            Destroy(gameObject);
          
        }
    }

}
