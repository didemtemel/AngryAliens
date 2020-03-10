using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gameScript : MonoBehaviour
{
    public GameObject tank;
    public GameObject enemy;
    public GameObject ball;
    public InputField acitxt;
    public InputField hiztxt;
    public Text hitpoint;
    public GameObject WinningPanel;
    public GameObject LosingPanel;


    public int hitCount = 10;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
    }
    bool isRight = true;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (!isRight)
            {
                isRight = true;
                tank.transform.localScale = new Vector3(0.3f, 0.3f, 1);
            }
            tank.transform.position += new Vector3(0.05f, 0, 0);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (isRight)
            {
                isRight = false;
                tank.transform.localScale = new Vector3(-0.3f, 0.3f, 1);

            }
            tank.transform.position -= new Vector3(0.05f, 0, 0);
        }
    }
    public void atesEt()
    {
        float hiz = float.Parse(hiztxt.text);
        float aci = float.Parse(acitxt.text);
        float xdimension = hiz * Mathf.Cos(aci * Mathf.Deg2Rad);
        float ydimension = hiz * Mathf.Sin(aci * Mathf.Deg2Rad);

        Vector3 force = new Vector3(xdimension, ydimension, 0);

        GameObject ucobje = GameObject.Find("uc");
        //parent sayesinde bir üstündeki objeyi bulduk.
        ucobje.transform.parent.gameObject.transform.eulerAngles = new Vector3(0, 0, aci);
       
        GameObject newball = Instantiate(ball, ucobje.transform.position, Quaternion.identity);
        newball.GetComponent<Rigidbody2D>().AddForce(force);
        newball.GetComponent<Rigidbody2D>().gravityScale = 1;
    
        hitCount = hitCount - 1;
        hitpoint.text = hitCount.ToString();

        if(hitCount == -1 )
        {
            LosingPanel.SetActive(true);
        }

    }

    public void SpawnEnemy()
    {
        enemy.GetComponent<Rigidbody2D>().AddForce(new Vector3(-10, 0));
        for(int i = 1; i<3; i++)
        {
            GameObject enemies = Instantiate(enemy, enemy.transform.position + new Vector3(5*i, 0), Quaternion.identity);
            enemies.GetComponent<Rigidbody2D>().AddForce(new Vector3(-10, 0));
            enemies.name = "enemy" + i;
        }


    }
}
