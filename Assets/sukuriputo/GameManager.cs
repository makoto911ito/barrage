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

    [SerializeField] GameObject m_scoaItem;

    [SerializeField] GameObject m_bossbox;

    [SerializeField] GameObject m_bossobj;

    [SerializeField] Bossmove m_bossmove;

    public int m_score = 0;


    private void Start()
    {

    }


    void Update()
    {
        m_scoreText.text = "score " + m_score.ToString();


        if(m_scoaItem == null && m_bossbox == null)
        {

        }
    }

}
