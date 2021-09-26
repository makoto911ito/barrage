using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour
{
    [SerializeField] GameObject m_boss;

    // Start is called before the first frame update
    void Start()
    {
        m_boss.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("EnemyBox") == null && GameObject.FindGameObjectWithTag("enemi") == null)
        {
            m_boss.gameObject.SetActive(true);
        }
    }
}
