using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dannmaku : MonoBehaviour
{
    public GameObject PlayerFirePrefab;
    private GameObject obj;
    private List<GameObject> obj2 = new List<GameObject>();
    //親オブジェクトのトランスフォームをアサイン
    public Transform Harpy;
    /// <summary>発射方向数 </summary>
    //public int wayNumber;
    public int m_PlayeLv = 1;

    // Update is called once per frame
    void Update()
    {
        Dbullet();
    }

    void Dbullet()
    {
        if(m_PlayeLv == 1)
        {
            Delete();

            if (Input.GetButtonDown("Jump"))
            {
                    // Instantiate()は、プレハブからクローンを産み出すメソッド（重要ポイント）
                    // Quaternion.Euler(x, y, z)
                    // 今回は「i = 0の時 → y = -30」「i = 1の時 → y = -15」「i = 2の時 → y = 0」「i = 3の時 → y = 15」「i = 4の時 → y = 15」になるようにする。
                    obj = Instantiate(PlayerFirePrefab, transform.position, Quaternion.identity);
                    obj.transform.SetParent(Harpy);
                    obj2.Add(obj);
            }

        }
        else if(m_PlayeLv == 2)
        {
            Delete();

            if (Input.GetButtonDown("Jump"))
            {
                for (int i = 0; i < 2; i++)
                {
                    obj = Instantiate(PlayerFirePrefab, transform.position, Quaternion.Euler(0, 0, 7.5f + (-15f * i)));
                    obj.transform.SetParent(Harpy);
                    obj2.Add(obj);
                    Debug.Log(obj2.Count);
                    Debug.Log(obj2[i].name);
                }
            }
        }
        else if(m_PlayeLv == 3)
        {
            Delete();

            if (Input.GetButtonDown("Jump"))
            {
                for (int i = 0; i < 3; i++)
                {
                    obj = Instantiate(PlayerFirePrefab, transform.position, Quaternion.Euler(0, 0, 15f + (-15f * i)));
                    obj.transform.SetParent(Harpy);
                    obj2.Add(obj);
                    Debug.Log(obj2.Count);
                    Debug.Log(obj2[i].name);
                }
            }
        }
    }

    void Delete()
    {
        if (Input.GetButtonUp("Jump"))
        {
            for (int i = 0; i < obj2.Count; i++)
            {
                Debug.Log("mawaru");
                Destroy(obj2[i]);
                Debug.Log(i);
            }
            obj2.Clear();
            Debug.Log(obj2.Count);
        }
    }
}
