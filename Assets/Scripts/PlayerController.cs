using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] Animator _playerAnim;
    private Transform _cameraTransform;
    [SerializeField] private float rotationSpeed;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked; // oyun oynarken ımlecı orataya sabıtlıyor gozukmuyor..
        _cameraTransform = Camera.main.transform; 
    }

    private void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * _speed, 0,
            Input.GetAxis("Vertical") * Time.deltaTime * _speed)); 
        
        _playerAnim.SetFloat("MoveX", Input.GetAxis("Horizontal"));
        _playerAnim.SetFloat("MoveZ", Input.GetAxis("Vertical"));
        
        Quaternion targetRotation = Quaternion.Euler(0,_cameraTransform.eulerAngles.y,0);
        transform.rotation = Quaternion.Lerp(transform.rotation,targetRotation,rotationSpeed * Time.deltaTime);
    }

}
