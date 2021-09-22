using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missil : MonoBehaviour
{
    public GameObject m_bulletPrefab;
    [SerializeField] float m_bspeed = 500;
    [SerializeField] float timeleft = 0.0f;

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
            Fire();
            timeleft = 0.1f;
        }
    }

    void Fire()
    {
        GameObject Bullet = Instantiate(m_bulletPrefab, transform.position, Quaternion.identity);
        Rigidbody2D bulletRb = Bullet.GetComponent<Rigidbody2D>();
        bulletRb.AddForce(transform.up * m_bspeed);
    }
}
