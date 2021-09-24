using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBox : MonoBehaviour
{
    [SerializeField] GameObject m_enemy;
    public float m_speed;
    [SerializeField] int m_enemynumber;

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
                GameObject enemey = Instantiate(m_enemy, transform.position, Quaternion.Euler(0, 0, 0));
                //Rigidbody enemyRb = enemey.GetComponent<Rigidbody>();
                //enemyRb.AddForce(transform.forward * m_speed);

                yield return new WaitForSeconds(0.2f);
            }

            yield return new WaitForSeconds(3f);
        }
    }
}
