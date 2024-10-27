using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab04Cube3 : MonoBehaviour
{
    void Start()
    {
        print("!");
    }

    // Update is called once per frame
    void Update()
    {
        bool incre = true;
        float maxScale = 5;
        float minScale = 1; 

       
        if (incre)
        {
            // Increase scale
            this.transform.localScale += Vector3.one * Time.deltaTime;
            if(transform.localScale.y >= maxScale)
                incre = false;

        }
         if(!incre)
        {
            this.transform.localScale -= Vector3.one * Time.deltaTime;
            if(transform.localScale.y <= minScale )
                incre = true;
        }
    }

}
