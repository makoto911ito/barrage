using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBox : MonoBehaviour
{
    [SerializeField] GameObject m_enemy;
    public float m_speed;
    [SerializeField] int m_enemynumber;
    [SerializeField] float m_timeA;
    [SerializeField] float m_timeB;
    [SerializeField] float m_timeleft;
    private float m_x;
    private float m_y;

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
                for (int i = 0; i < 3; i++)
                {
                    m_x = Random.Range(-2.5f, 2.6f);//x軸の-2.5～2.5の位置にランダムで生み出す範囲指定
                    m_y = Random.Range(-4f, 0.1f);//ｙ軸の-4～0の位置にランダムで生み出す範囲指定
                    GameObject enemey = Instantiate(m_enemy, new Vector3(transform.position.x + m_x, transform.position.y + m_y, transform.position.z), Quaternion.identity);
                    Rigidbody2D enemyRb = enemey.GetComponent<Rigidbody2D>();
                    enemyRb.AddForce(transform.forward * m_speed);

                    yield return new WaitForSeconds(m_timeA);
                }

                yield return new WaitForSeconds(m_timeB);

                if (j < m_enemynumber)
                {
                    Destroy(this.gameObject);
                }
            }
        }
    }
