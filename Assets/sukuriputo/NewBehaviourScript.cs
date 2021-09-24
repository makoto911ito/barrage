using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;

        if(pos.y == 5.5f)
        {
            rb.velocity = Vector3.zero;

            rb.AddForce(new Vector3(1, -3, 0) * Time.deltaTime * -30);
        }
    }
}
