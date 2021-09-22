using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nway : MonoBehaviour
{
    public GameObject PlayerFirePrefab;
    private GameObject obj;
    private List<GameObject> obj2 = new List<GameObject>();
    //親オブジェクトのトランスフォームをアサイン
    public Transform Harpy;
    /// <summary>発射方向数 </summary>
    public int wayNumber;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Jump"))
        {
            for (int i = 0; i < obj2.Count; i++)
            {
                Debug.Log("mawaru");
                Destroy(obj2[i]);
                //obj2.RemoveAt(i);
                Debug.Log(i);
            }
            obj2.Clear();
            Debug.Log(obj2.Count);

            //foreach(var index in obj2)
            //{
            //    Debug.Log("mawaru");
            //    Destroy(index);
            //    obj2.Remove(index);

            //}
        }

        if (Input.GetButtonDown("Jump"))
        {
            for (int i = 0; i < wayNumber; i++)
            {
                // Instantiate()は、プレハブからクローンを産み出すメソッド（重要ポイント）
                // Quaternion.Euler(x, y, z)
                // 今回は「i = 0の時 → y = -30」「i = 1の時 → y = -15」「i = 2の時 → y = 0」「i = 3の時 → y = 15」「i = 4の時 → y = 15」になるようにする。
                obj = Instantiate(PlayerFirePrefab, transform.position, Quaternion.identity);
                //obj = Instantiate(PlayerFirePrefab, transform.position, Quaternion.Euler(0, -30 + (15 * i), -30 + (15 * i)));
                obj.transform.SetParent(Harpy);
                obj2.Add(obj);
                Debug.Log(obj2.Count);
                Debug.Log(obj2[i].name);
            }
        }

    }
}
