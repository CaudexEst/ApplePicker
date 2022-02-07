/*
 * Created by: Ben Jenkins
 * Date created: 2/7/2022
 * Last Edited by: NA
 * Last edited: NA
 * Discription: Basket control and apple collection
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the current screen position of the mouse from input
        Vector3 mousePos2D = Input.mousePosition; //1

        //camer z position sets how far to push the mouse into 3D
        mousePos2D.z = -Camera.main.transform.position.z; //2

        //convert the point from 2D screen space to 3D game world space
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D); //3

        //move the x position of this basket to the x position of the mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;

    }
    private void OnCollisionEnter(Collision coll)
    {
        //Find what hit the basket
        GameObject collidedwith = coll.gameObject;
        if (collidedwith.tag == "Apple")
            Destroy(collidedwith);
    }
}
