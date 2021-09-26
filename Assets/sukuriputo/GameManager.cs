using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    /// <summary>スコア表示テキスト </summary>
    [SerializeField] Text m_scoreText = default;
    /// <summary>ゲームオーバーのテキスト</summary>
    [SerializeField] Text m_gameoverText;

    [SerializeField] Text m_bosslifeText;

    [SerializeField] Text m_clearText;

    [SerializeField] Text m_tscoaText;

    [SerializeField] GameObject m_scoaItem;

    [SerializeField] GameObject m_Boss;

    [SerializeField] GameObject m_bossobj;

    [SerializeField] Bossmove m_bossmove;

    [SerializeField] AudioSource m_soundA;

    [SerializeField] AudioSource m_soundB;

    [SerializeField] Button m_boton;

    [SerializeField] float m_timeleft;

    [SerializeField] float m_time;

    public int m_score = 0;


    private void Start()
    {
        m_clearText.enabled = false;
        m_gameoverText.enabled = false;
        m_boton.gameObject.SetActive(false);
        m_time = m_timeleft;
    }


    void Update()
    {
        m_scoreText.text = "score " + m_score.ToString();

        if (GameObject.FindGameObjectWithTag("Boss") == true)
        {
            m_soundA.enabled = false;
            m_soundB.enabled = true;

        }

        if (GameObject.FindGameObjectWithTag("EnemyBox") == null && GameObject.FindGameObjectWithTag("enemi") == null)
        {
            m_time -= Time.deltaTime;
            if (m_time <= 0 && GameObject.FindGameObjectWithTag("Boss") == null)
            {
                m_time = m_timeleft;
                if (m_time <= 0 && GameObject.FindGameObjectWithTag("score") == null)
                {
                    m_clearText.enabled = true;
                    m_scoreText.enabled = false;
                    m_tscoaText.enabled = true;
                    m_boton.gameObject.SetActive(true);
                    m_tscoaText.text = "獲得スコア　" + m_score.ToString();
                }
            }

        }

        if (GameObject.FindGameObjectWithTag("Plaeyr") == null)
        {
            m_gameoverText.enabled = true;
            m_boton.gameObject.SetActive(true);

        }
    }

}
