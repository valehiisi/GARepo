using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class mainchar : MonoBehaviour
{

    public float speed = 1;

    Rigidbody2D rb = null;

    float scaleX = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        scaleX = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.right * Input.GetAxis("Horizontal") * speed + Vector2.up * rb.velocity.y;

        //flip the character
        if(Input.GetAxis("Horizontal") != 0)
            {
            int direction = 1;
                
            if(Input.GetAxis("Horizontal") < 0)
                {
                    direction = -1;
            }
            transform.localScale = new Vector3(scaleX * direction, transform.localScale.y, transform.localScale.z);
        
        }

        
    }
}
