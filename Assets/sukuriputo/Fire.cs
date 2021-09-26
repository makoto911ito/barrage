﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

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
        GameObject Bullet = Instantiate(m_Ebullert, transform.position, Quaternion.identity);
        Rigidbody2D bulletRb = Bullet.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(transform.up * m_bspeed);

        Destroy(Bullet, 30f);

        //if (m_time > 3)
        //{
        //    Instantiate(m_Ebullert, new Vector3(enemi.position.x - 50, enemi.position.y, enemi.position.z),Quaternion.identity);
        //}

    }
    //void OnBecameVisible()
    //{
    //    if (!m_hanntei)
    //    {
    //        m_hanntei = true;
    //        Debug.Log("起動");
    //        obj = Instantiate(PlayerFirePrefab, transform.position, Quaternion.identity); //銃口を生成しそれをobjに代入している
    //        obj.transform.SetParent(enemi); //objをHarpy(プレイヤー)の子供にする
    //        obj2.Add(obj); //obj2のリストにobjを加えていく
    //    }
    //}
}

