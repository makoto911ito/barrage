using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMissil : MonoBehaviour
{

    /// <summary>生み出す銃口を入れる箱</summary>
    private GameObject obj;
    /// <summary>銃口の箱を保存する場所</summary>
    private List<GameObject> obj2 = new List<GameObject>();
    [SerializeField] GameObject m_Ebullert;
    [SerializeField] GameObject m_Ebullert2;
    //親オブジェクトのトランスフォームをアサイン
    [SerializeField] Transform enemi;
    private Transform tf;
    float m_time = 0;
    private bool m_hanntei = false;
    /// <summary>待機時間</summary>
    [SerializeField] float timeleft = 0.0f;
    /// <summary>弾幕のスピード</summary>
    [SerializeField] float m_bspeed = -500;

    [SerializeField] Bossmove m_bossmove;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;
        if (timeleft <= 0.0)
        {
            if(m_bossmove.m_blife > 250)
            {
                Ebbullet();
                timeleft = 0.5f;
            }
            else if(m_bossmove.m_blife < 250)
            {

            }
            timeleft = 0.5f;
        }

    }

    void Ebbullet()
    {

        GameObject Bullet = Instantiate(m_Ebullert, transform.position, Quaternion.identity);
        //Bullet.transform.SetAsLastSibling();
        Rigidbody2D bulletRb = Bullet.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(transform.up * m_bspeed);

        GameObject Bullet2 = Instantiate(m_Ebullert2, transform.position, Quaternion.identity);
        //Bullet2.transform.SetAsLastSibling();
        Rigidbody2D bulletRb2 = Bullet.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(transform.up * m_bspeed);

        Destroy(Bullet, 40f);
    }

    void EBbullet()
    {

    }
}
