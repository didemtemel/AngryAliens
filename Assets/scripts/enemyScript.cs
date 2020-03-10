using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemyScript : MonoBehaviour
{
    public GameObject LosingPanel;
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
        if(collision.gameObject.tag == "tank")
        {
            Debug.Log("Tankı vurdun");
            Destroy(collision.gameObject);
            LosingPanel.SetActive(true);
            


        }
    }
}
