using UnityEngine;
using UnityEngine.AI;

namespace Enemy
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class EnemyPattern1 : EnemyBase
    {
        private GameObject _player;
        private NavMeshAgent _me;
        private void Start()
        {
            _player = GameObject.Find("Player");
            _me = gameObject.GetComponent<NavMeshAgent>();
        }
        private void Update()
        {
            Move(_me, _player);
        }
    }
}