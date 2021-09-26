using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emissil : MonoBehaviour
{
    public GameObject m_bulletPrefab;
    /// <summary>弾幕のスピード</summary>
    [SerializeField] float m_bspeed = -500;
    /// <summary>待機時間</summary>
    [SerializeField] float m_timeleft = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        m_timeleft -= Time.deltaTime;
        if (m_timeleft <= 0.0)
        {
            Fire();
            m_timeleft = 1f;
        }
    }

    void Fire()
    {
        GameObject Bullet = Instantiate(m_bulletPrefab, transform.position, Quaternion.identity);
        Rigidbody2D bulletRb = Bullet.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(transform.up * m_bspeed);

        Destroy(Bullet, 10f);
    }
}
