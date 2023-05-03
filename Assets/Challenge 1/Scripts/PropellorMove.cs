using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellorMove : MonoBehaviour
{

    private float MAX_ROT = 40f;
    private float MIN_ROT = 0f;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RotUp() 
    {
        
        transform.Rotate(speed * Time.deltaTime * Vector3.left);
    }
}
