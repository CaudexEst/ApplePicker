/*
 * Created by: Ben Jenkins
 * Date created: 1/31/2022
 * Last Edited by: NA
 * Last edited: NA
 * Description: Controls tree movement and apple spawning
 */
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 24f;
    public float chanceToChangeDirections = 0.1f;
    public float secondsBetweenAppleDrops = 1f;
    
    
    
    // Start is called before the first frame update 
    
    void Start()
    {
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    // Update is called once per frame
    void Update()
    {
        //Move every tree
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if(pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);//move right
        }
        else if(pos.x >leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);//move left
        }
    }

    private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1; //chanceToChangeDirections directions 
        }
    }
}
