using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject player;
    public GameObject objToHide;
    void Start()
    {
        player = GameObject.Find("Convai Player Character");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        Debug.Log("The distance is:" + distance );
        if(distance < 25f ){
            objToHide.SetActive(true);
            Debug.Log("Convai Active" );

        }else{
            objToHide.SetActive(false);
            Debug.Log("Convai Inactive" );
        }

    }
}
