using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ballScript : MonoBehaviour
{
    public GameObject WinningPanel;

    public int countDead = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Çarpışma gerçekleşti");
        if(collision.gameObject.tag == "enemy")
        {
            Debug.Log("Düşmanı vurdun");
            collision.gameObject.GetComponent<Animator>().Play("burn");
            Destroy(collision.gameObject,1);
            Destroy(this.gameObject);
            countDead = countDead - 1;
            if( countDead == 0 )
            {
                WinningPanel.SetActive(true);
            }
            Debug.Log(countDead);


        }
    }

}
