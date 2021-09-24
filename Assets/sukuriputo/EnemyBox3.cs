using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBox3 : MonoBehaviour
{

    [SerializeField] GameObject m_enemy;
    public float m_speed;
    [SerializeField] int m_enemynumber;
    private Rigidbody2D m_rb;
    private float m_x;
    private float m_y;
    private Transform m_tf;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GeneEnemy());


    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator GeneEnemy()
    {
        for (int j = 0; j < m_enemynumber; j++)
        {
            for (int i = 0; i < 2; i++)
            {
                m_x = Random.Range(-2.5f, 2.6f);
                m_y = Random.Range(-4f, 0.1f);
                GameObject enemey = Instantiate(m_enemy, new Vector3(transform.position.x + m_x, transform.position.y + m_y, transform.position.z), Quaternion.identity);
                Rigidbody2D enemyRb = enemey.GetComponent<Rigidbody2D>();
                enemyRb.AddForce(transform.forward * m_speed);

                yield return new WaitForSeconds(10f);
            }

            yield return new WaitForSeconds(3f);
        }
    }
}
