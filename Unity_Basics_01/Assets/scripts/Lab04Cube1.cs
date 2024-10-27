
using UnityEngine;

public class Lab04Cube1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello ");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Vector3.up);
    }
}
