using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour
{
    public GameObject floor;
    public float floorborder;
    public GameObject player;
    public bool floorcount;
    public GameObject goal;
    public int createcount;
    // 0になったらBlockオブジェクトを生成
    float _timer = 0;
    // トータルの経過時間を保持
    float _totalTime = 0;
    // ①ブロック生成回数
    int _cnt = 0;
    // Start is called before the first frame update
    void Start()
    {
         player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer < 0 && floorcount==false)
        {
            floorcount = true;
            Vector3 position = transform.position;
            // ※上下(±3)のランダムな位置に出現させる
            position.y = Random.Range(-3, 3);
            Debug.Log("s");
            //床をplayerの10f先とカメラの位置からランダムなｙの座標を生成する
            GameObject obj = Instantiate(floor, new Vector2( player.transform.position.x + 10f, transform.position.y+position.y), transform.rotation);
           
            _timer += 1;
            createcount++;
            floorcount = false;
            //5秒後に床が壊れる
            Destroy(obj,5f);
            Debug.Log("f");
           if(createcount==3)
            {
                CreateClearPosition(obj);
            }
        }
    }
    void CreateClearPosition(GameObject obj)
    {
        Instantiate(goal, new Vector2(obj.transform.position.x,obj.transform.position.y+0.5f),transform.rotation);
    }
    
}