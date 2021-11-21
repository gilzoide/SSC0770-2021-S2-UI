using System.Collections;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 Speed = new Vector3(30, 30, 30);

    void Update()
    {
        transform.Rotate(Speed * Time.deltaTime);
    }
}
