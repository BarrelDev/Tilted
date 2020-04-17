using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject jumpParent;
    public GameObject speedParent;
    public GameObject tileParent;
    GameObject tile;
    GameObject jumpBoost;
    GameObject speedBoost;
    Vector2 tilePos;
    Vector2 jumpPos;
    Vector2 speedPos;
    Quaternion rotation = new Quaternion();

    // Start is called before the first frame update
    void Start()
    {
        tilePos = tileParent.transform.position;
        jumpPos = new Vector3(-714.11f, 19.73f, 812.6243f);
        speedPos = new Vector3(-686.7916f, 20.2367f, 812.6243f);
    }

    // Update is called once per frame
    void Update()
    {
        tile = Instantiate(tileParent, new Vector2(tilePos.x + Random.Range(25f, 50f), tilePos.y + Random.Range(-2f, 10f)), rotation);
        tilePos = tile.transform.position;
        GeneratePowerUps();
    }

    void GeneratePowerUps()
    {
        if (Random.Range(0f, 10f) <= 5f)
        {
            jumpBoost = Instantiate(jumpParent, new Vector2(jumpPos.x + Random.Range(25f, 150f), jumpPos.y + Random.Range(-1f, 10f)), rotation);
            jumpPos = jumpBoost.transform.position;
        }
        else
        {
            speedBoost = Instantiate(speedParent, new Vector2(speedPos.x + Random.Range(25f, 150f), speedPos.y + Random.Range(-1f, 10f)), rotation);
            speedPos = speedBoost.transform.position;
        }
    }
}
