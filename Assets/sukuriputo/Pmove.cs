using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pmove : MonoBehaviour
{
    private Rigidbody2D m_playerRb;
    private Vector3 pos;

    /// <summary>プレイヤーの速度</summary>
    [SerializeField] float m_pSpeed = 2f;
    [SerializeField] int m_Plife = 0;
    [SerializeField] Dannmaku m_dannmaku;
    [SerializeField] float m_exp = 0f;
    [SerializeField] float m_kexp = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        //リジットボディ２Dを持ってくる
        m_playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
        if(m_Plife <= 0)
        {
            Destroy(this.gameObject);
            Debug.Log("ゲームオーバー");
        }

        if(m_exp > 1.0f)
        {
            m_dannmaku.m_PlayeLv += 1;
            m_exp = 0f;
        }
    }

    void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector2 velocity = m_playerRb.velocity;

        // hとvに＊m_pSpeed分進む
        velocity.x = h * m_pSpeed;
        velocity.y = v * m_pSpeed;

        m_playerRb.velocity = velocity;

        MoveClamp();
    }

    void MoveClamp()
    {
        pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -3, 3);
        pos.y = Mathf.Clamp(pos.y, -5, 7);

        transform.position = pos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ebullet")
        {
            m_Plife -= 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "exp")
        {
            m_exp += m_kexp;
        }
    }
}
