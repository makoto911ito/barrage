﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    /// <summary>スコア表示テキスト </summary>
    [SerializeField] Text m_scoreText = default;
    /// <summary>ゲームオーバーのテキスト</summary>
    [SerializeField] Text m_gameoverText;

    public int m_score = 0;


    void Update()
    {
        m_scoreText.text = "score " + m_score.ToString();
    }
}
