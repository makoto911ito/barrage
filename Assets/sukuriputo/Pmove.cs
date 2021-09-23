using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pmove : MonoBehaviour
{
    private Rigidbody2D m_playerRb;
    private Vector2 pos;

    /// <summary>プレイヤーの速度</summary>
    [SerializeField] float m_pSpeed = 2f;
    [SerializeField] int m_Plife = 0;
    [SerializeField] Dannmaku m_dannmaku;
    [SerializeField] GameManager m_gm;
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

        //ゲームオーバーの条件
        if (m_Plife <= 0)
        {
            Destroy(this.gameObject);
            Debug.Log("ゲームオーバー");
        }

        //レベルアップの条件
        if (m_exp > 1.0f)
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

        //範囲の座標を指定する。
        pos.x = Mathf.Clamp(pos.x, -2.5f, 2.5f);
        pos.y = Mathf.Clamp(pos.y, -4, 4);

        transform.position = pos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "exp")
        {
            //当たったオブジェクトの親を代入してくる
            GameObject m_gob = collision.transform.parent.gameObject;
            Destroy(m_gob);　//取得した親オブジェクトを消す
            m_exp += m_kexp;　//取得経験値を累計経験値に足していく
        }

        if (collision.gameObject.tag == "score")
        {
            //当たったオブジェクトの親を代入してくる
            GameObject m_gob = collision.transform.parent.gameObject;
            Destroy(m_gob); //取得した親オブジェクトを消す
            m_gm.m_score += 100;
        }

        //敵が放つ弾幕に触れた場合か、敵自体に触れたときにプレイヤーのHPを１マイナスする。
        if (collision.gameObject.tag == "Ebullet" || collision.gameObject.tag == "enemi")
        {
            m_Plife -= 1;
        }

    }
}
