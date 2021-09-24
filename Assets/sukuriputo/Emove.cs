using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emove : MonoBehaviour
{
    /// <summary>敵の最大ライフ</summary>
    [SerializeField] int m_elife = 5;
    /// <summary>ゲームマネージャーを参照するための道具</summary>
    public GameManager m_gm;
    /// <summary>敵を倒したときのスコア</summary>
    public int m_eScore = 10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(m_elife <= 0)　//敵のライフが０の時、その敵を消し、累計スコアにこの敵が持っていたスコアを足していく
        {
            Destroy(this.gameObject);
            m_gm.m_score += m_eScore;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)　//プレイヤーの放つ弾幕が当たった時自分（敵）ライフを１減らす
    {
        if (collision.gameObject.tag =="Bullet")
        {
            m_elife -= 1;
        }
    }
}
