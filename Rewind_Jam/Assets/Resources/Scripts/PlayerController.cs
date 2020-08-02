using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 3;
    public GameObject RespawnPointPrefab;

    public GameObject RespawnPoint { get; private set; }
    public bool RespawnSet { get; private set; }

    private void Start()
    {
        RespawnPoint = Instantiate(RespawnPointPrefab, GameManager.Instance.transform);
        RespawnPoint.SetActive(false);
    }

    public void Move(Vector3 dir)
    {
        transform.Translate(dir * Speed * Time.deltaTime);
    }

    public void SetRespawnPoint()
    {
        RespawnPoint.SetActive(true);
        RespawnPoint.transform.SetPositionAndRotation(transform.position, transform.rotation);
        RespawnSet = true;
    }

    public void WarpToRespawnPoint()
    {
        transform.SetPositionAndRotation(RespawnPoint.transform.position, RespawnPoint.transform.rotation);
        RespawnPoint.SetActive(false);
        RespawnSet = false;
    }
}
