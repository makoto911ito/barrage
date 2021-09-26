using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bossmove : MonoBehaviour
{

    /// <summary>敵の最大ライフ</summary>
    public int m_blife = 500;
    /// <summary>スコアアイテム</summary>
    public GameObject m_scoaItem;
    /// <summary>敵を倒したときのスコア</summary>
    public int m_eScore = 10000;
    private GameObject m_go;
    private GameManager m_gm;
    private float m_x;
    private float m_y;

    public Slider hpSlider;

    public Animator m_Anime;


    // Start is called before the first frame update
    void Start()
    {
        m_Anime = GetComponent<Animator>();
        m_Anime.SetBool("Step1", false);
        m_Anime.SetBool("Step2", false);

        m_go = GameObject.FindGameObjectWithTag("GameManager");
        m_gm = m_go.GetComponent<GameManager>();

        // スライダーの最大値の設定
        hpSlider.maxValue = m_blife;

        // スライダーの現在値の設定
        hpSlider.value = m_blife;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_blife <= 0)　//敵のライフが０の時、その敵を消し、累計スコアにこの敵が持っていたスコアを足していく
        {
            for (int i = 0; i < 10; i++)
            {
                m_x = Random.Range(-0.6f, 0.5f);//x軸の-0.2.～0.2の位置にランダムで生み出す範囲指定
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
            m_blife -= 1;
            hpSlider.value = m_blife;
        }
    }
}
