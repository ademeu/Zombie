using System;
using UnityEngine;
using UnityEngine.AI;

public class FllowPlayer : MonoBehaviour
{
    #region NavMash'den oncesi
    //  private GameObject _player;
    //  [SerializeField] private Animator _zombieAnimator;
    //
    //  private void Start()
    //  {
    //      _player = FindObjectOfType<PlayerController>().gameObject;
    //  }
    //  private void Update()
    // {
    //     transform.position =Vector3.MoveTowards(this.transform.position, _player.transform.position, 1f * Time.deltaTime);
    //     Vector3 relativePos = _player.transform.position - transform.position;
    //     transform.rotation = Quaternion.LookRotation(relativePos, Vector3.up);
    // }
     #endregion

     [SerializeField] private Transform _player;
     private NavMeshAgent _nMash;

     private void Awake()
     {
         _player = FindObjectOfType<PlayerController>().transform;
         _nMash = GetComponent<NavMeshAgent>();
     }

     private void Update()
     {
         _nMash.SetDestination(_player.position);
     }
}
