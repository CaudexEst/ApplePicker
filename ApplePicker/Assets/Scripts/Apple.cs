/*
 * Created by: Ben Jenkins
 * Date created: 1/31/2022
 * Last Edited by: NA
 * Last edited: NA
 * Description: Apple despawn logic
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<bottomY)
        {
            Destroy(this.gameObject);

            GameObject gm = GameObject.Find("GameManager");
            ApplePicker aScript = Camera.main.GetComponent<ApplePicker>();
            aScript.AppleDestroyed();
        }
    }
}
