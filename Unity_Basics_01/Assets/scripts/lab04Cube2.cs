using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab04Cube2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("World ");
    }

    // Update is called once per frame
    void Update()
    {
        float someDist = 10f;
        float returnPosition = 0f;

        if (this.transform.position.z <= someDist && this.transform.position.z >= returnPosition)
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime);
        }
        else if(this.transform.position.z >= someDist)
        {
            this.transform.Translate(Vector3.back);
        }
        else if(this.transform.position.z <= returnPosition)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, returnPosition);
        }
    }
}
