using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MoveConstant class
public class MoveConstant : MonoBehaviour
{
    public float Speed; // Float speed

    // Update per passing frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * Speed); // Transform 'right' relative to mulitplier
        if (transform.position.x > 500f) // If transform is larger than '0', do the following
        {
            transform.position = new Vector3(transform.position.x, 0, 0); // Transform position in 'X' axis only
        }
    }
}