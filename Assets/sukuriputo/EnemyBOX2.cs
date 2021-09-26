using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBOX2 : MonoBehaviour
{

    [SerializeField] GameObject m_enemy;
    public float m_speed;
    [SerializeField] int m_enemynumber;
    private Rigidbody2D m_rb;
    private float m_x;
    private float m_y;
    private Transform m_tf;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("EnemyBox") == null)
        {
            gameObject.SetActive(true);
        }
    }
}
