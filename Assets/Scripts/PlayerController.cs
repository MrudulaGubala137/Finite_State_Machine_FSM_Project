using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    bool isDead = false;
    public GameObject enemy;
    public float playerSpeed;
    public float rotationSpeed;
    public Vector3 targetVelocity;
    Rigidbody rb;
    void Start()
    {
       /* rb=GetComponent<Rigidbody>();
        rb.useGravity=false;
        rb.freezeRotation=true;*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FixedUpdate()
    {
       // transform.Rotate(0f, Input.GetAxis("Mouse Y")*rotationSpeed, 0f);
    }
    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag =="Coin")
        {
            Destroy(collision.gameObject);
        }
        
    }
}
