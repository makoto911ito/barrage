using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Rigidbody2D m_rb;
    [SerializeField] float m_speed;

    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        m_rb.AddForce(new Vector2(0, -1) * m_speed, ForceMode2D.Force);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 2)
        {
            m_rb.velocity = Vector3.zero;

        }
    }
}
