using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applyforces : MonoBehaviour
{
    Rigidbody ourRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ourRigidBody.AddExplosionForce(1000,transform.position+Vector3.down,2);
        }
            
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.position += Vector3.down;
    }
}