using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire2 : MonoBehaviour
{

    /// <summary>生み出す銃口を入れる箱</summary>
    private GameObject obj;
    /// <summary>銃口の箱を保存する場所</summary>
    private List<GameObject> obj2 = new List<GameObject>();
    [SerializeField] GameObject m_Ebullert;
    //親オブジェクトのトランスフォームをアサイン
    [SerializeField] Transform enemi;
    /// <summary>待機時間</summary>
    [SerializeField] float m_timeleft = 0.0f;
    /// <summary>弾幕のスピード</summary>
    [SerializeField] float m_bspeed = -500;

    private float timeleft;


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
            Edbullet();
            timeleft = m_timeleft;
        }
        //OnBecameVisible();

    }

    void Edbullet()
    {
        GameObject Bullet = Instantiate(m_Ebullert, transform.position, Quaternion.Euler(0,0,-7.5f));
        Rigidbody2D bulletRb = Bullet.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(transform.up * m_bspeed);
        GameObject Bullet2 = Instantiate(m_Ebullert, transform.position, Quaternion.Euler(0,0,7.5f));
        Rigidbody2D bulletRb2 = Bullet2.GetComponent<Rigidbody2D>();
        bulletRb2.AddForce(transform.up * m_bspeed);


        Destroy(Bullet, 30f);
    }
}
