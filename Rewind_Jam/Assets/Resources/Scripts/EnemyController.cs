using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public PlayerController Player;
    public float Speed = 3;

    private void Update()
    {
        Vector3 vec = (Player.transform.position - transform.position);
        vec.y = 0;
        transform.Translate(vec.normalized * Speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        PlayerController player = collision.collider.GetComponent<PlayerController>();
        if (player != null)
        {
            Time.timeScale = 0;
            Debug.Log("Game Over");
        }
    }
}
