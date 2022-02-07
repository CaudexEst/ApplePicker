/*
 * Created by: Ben Jenkins
 * Date created: 2/7/2022
 * Last Edited by: NA
 * Last edited: NA
 * Discription: Basket creation
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketbottomY = -14f;
    public float basketSpacingY = 2f;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<numBaskets;i++)
        {
            GameObject tBasketGO = Instantiate(basketPrefab) as GameObject;
            Vector3 pos = Vector3.zero;
            pos.y = basketbottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
