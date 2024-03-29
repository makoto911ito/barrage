﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emove : MonoBehaviour
{
    /// <summary>敵の最大ライフ</summary>
    [SerializeField] int m_elife = 5;
    /// <summary>スコアアイテム</summary>
    [SerializeField] GameObject m_scoaItem;
    /// <summary>expアイテム</summary>
    [SerializeField] GameObject m_expItem;
    /// <summary>敵を倒したときのスコア</summary>
    public int m_eScore = 10;
    private GameObject m_go;
    private GameManager m_gm;
    private float m_x;
    private float m_y;


    // Start is called before the first frame update
    void Start()
    {
        m_go = GameObject.FindGameObjectWithTag("GameManager");
        m_gm = m_go.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_elife <= 0)　//敵のライフが０の時、その敵を消し、累計スコアにこの敵が持っていたスコアを足していく
        {
            for (int i = 0; i < 3; i++)
            {
                m_x = Random.Range(-0.2f, 0.3f);//x軸の-0.2.～0.2の位置にランダムで生み出す範囲指定
                m_y = Random.Range(-0.2f, 0.3f);//y軸の-0.2.～0.2の位置にランダムで生み出す範囲指定
                Instantiate(m_expItem, new Vector3(transform.position.x + m_x, transform.position.y + m_y, transform.position.z), Quaternion.identity);
                m_x = Random.Range(-0.2f, 0.3f);//x軸の-0.2.～0.2の位置にランダムで生み出す範囲指定
                m_y = Random.Range(-0.2f, 0.3f);//ｙ軸の-0.2～0.2の位置にランダムで生み出す範囲指定
                Instantiate(m_scoaItem, new Vector3(transform.position.x + m_x, transform.position.y + m_y, transform.position.z), Quaternion.identity);
            }
            Destroy(this.gameObject);
            m_gm.m_score += m_eScore;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)　//プレイヤーの放つ弾幕が当たった時自分（敵）ライフを１減らす
    {
        if (collision.gameObject.tag == "Bullet")
        {
            m_elife -= 1;
        }
    }
}
