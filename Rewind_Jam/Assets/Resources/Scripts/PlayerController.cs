using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 3;

    public void Move(Vector3 dir)
    {
        transform.Translate(dir * Speed * Time.deltaTime);
    }
}
