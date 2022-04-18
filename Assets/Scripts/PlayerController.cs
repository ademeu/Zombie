using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] Animator _playerAnim;

    private void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * _speed, 0,
            Input.GetAxis("Vertical") * Time.deltaTime * _speed);
        _playerAnim.SetFloat("MoveX", Input.GetAxis("Horizontal"));
        _playerAnim.SetFloat("MoveZ", Input.GetAxis("Vertical"));
    }

}
