using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FllowPlayer : MonoBehaviour
{
     private GameObject _player;
     [SerializeField] private Animator _zombieAnimator;

     private void Start()
     {
         _player = FindObjectOfType<PlayerController>().gameObject;
     }

     private void Update()
    {
        transform.position =
            Vector3.MoveTowards(this.transform.position, _player.transform.position, 1f * Time.deltaTime);

        Vector3 relativePos = _player.transform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos, Vector3.up);
    }
}
