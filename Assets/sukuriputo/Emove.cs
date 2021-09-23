using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emove : MonoBehaviour
{
    [SerializeField] int m_elife = 5;
    [SerializeField] GameManager m_gm;
    [SerializeField] int m_eScore = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(m_elife <= 0)
        {
            Destroy(this.gameObject);
            m_gm.m_score += m_eScore;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="Bullet")
        {
            m_elife -= 1;
        }
    }
}
