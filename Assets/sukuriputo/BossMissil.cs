using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMissil : MonoBehaviour
{
    [SerializeField] GameObject m_Ebullert;
    [SerializeField] GameObject m_Ebullert2;
    /// <summary>待機時間</summary>
    [SerializeField] float timeleft;
    /// <summary>弾幕のスピード</summary>
    [SerializeField] float m_bspeed = -500;

    [SerializeField] Bossmove m_bossmove;

    public Bossmove m_boss;

    private float m_x;
    private float m_y;


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
            Ebbullet();
            timeleft = 3f;

            if(m_bossmove.m_blife == 400)
            {
                for (int i = 0; i < 10; i++)
                {
                    m_x = Random.Range(-0.6f, 0.5f);//x軸の-0.2.～0.2の位置にランダムで生み出す範囲指定
                    m_y = Random.Range(-0.2f, 0.3f);//ｙ軸の-0.2～0.2の位置にランダムで生み出す範囲指定
                    Instantiate(m_boss.m_scoaItem, new Vector3(transform.position.x + m_x, transform.position.y + m_y, transform.position.z), Quaternion.identity);
                }
            }

            if(m_bossmove.m_blife == 300)
            {
                for (int i = 0; i < 10; i++)
                {
                    m_x = Random.Range(-0.6f, 0.5f);//x軸の-0.2.～0.2の位置にランダムで生み出す範囲指定
                    m_y = Random.Range(-0.2f, 0.3f);//ｙ軸の-0.2～0.2の位置にランダムで生み出す範囲指定
                    Instantiate(m_boss.m_scoaItem, new Vector3(transform.position.x + m_x, transform.position.y + m_y, transform.position.z), Quaternion.identity);
                }
            }

            if (m_bossmove.m_blife < 400)
            {
                Debug.Log("うごいた");
                m_bossmove.m_Anime.SetBool("Step1", true);
                timeleft = 1f;
            }
            else if(m_bossmove.m_blife > 300)
            {
                m_bossmove.m_Anime.SetBool("Step1", false);
                m_bossmove.m_Anime.SetBool("Step2", true);
            }
            else if(m_bossmove.m_blife < 100)
            {
                timeleft = 0.5f;
            }
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
