using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class ObjectBehavior : MonoBehaviour
{
    public bool IsHere;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Kid"))
        {
            Destroy(collision.gameObject);
            IsHere = false;
        }
    }
}
