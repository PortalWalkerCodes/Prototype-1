using Unity.Services.Lobbies.Models;
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    int _speed = 20; 

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
    }

    void CalculateMovement()
    {
       transform.Translate(_speed * Time.deltaTime * Vector3.forward);
    }
}
