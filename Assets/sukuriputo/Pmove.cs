using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pmove : MonoBehaviour
{
    private Rigidbody2D m_playerRb;

    /// <summary>弾幕のこと</summary>
    public GameObject bullet;
    /// <summary>プレイヤーの名前</summary>
    public Transform Harpy;

    /// <summary>プレイヤーの速度</summary>
    [SerializeField] float m_pSpeed = 2f;
    /// <summary>弾幕の速度</summary>
    [SerializeField] float m_bSpeed = 30f;

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
        Flring();
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
    }

    void Flring()
    {
        GameObject bullets = Instantiate(bullet) as GameObject;
        Vector2 a;
        a = this.gameObject.transform.forward * m_bSpeed;

        bullets.GetComponent<Rigidbody2D>().AddFprce(a);

        bullets.transform.position = Harpy.position;


    }
}
