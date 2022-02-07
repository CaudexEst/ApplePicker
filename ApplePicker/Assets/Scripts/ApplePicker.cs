/*
 * Created by: Ben Jenkins
 * Date created: 2/7/2022
 * Last Edited by: NA
 * Last edited: NA
 * Description: Basket creation
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    public List<GameObject> basketList;
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketbottomY = -14f;
    public float basketSpacingY = 2f;
    // Start is called before the first frame update
    void Start()
    {
        basketList = new List<GameObject>();
        for(int i=0;i<numBaskets;i++)
        {
            GameObject tBasketGO = Instantiate(basketPrefab) as GameObject;
            Vector3 pos = Vector3.zero;
            pos.y = basketbottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AppleDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach(GameObject tGo in tAppleArray)
        {
            Destroy(tGo);
        }
        int basketIndex = basketList.Count - 1;
        GameObject tbasketGO = basketList[basketIndex];
        basketList.RemoveAt(basketIndex);
        Destroy(tbasketGO);

        if (basketList.Count == 0) 
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
