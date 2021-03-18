using UnityEngine;
using UnityEngine.AI;

namespace Scripts.Enemy
{
    public abstract class EnemyBase : MonoBehaviour
    {
        virtual protected void Move(NavMeshAgent my, GameObject target)
        {
            if (target != null)
            {
                my.destination = target.transform.position;
            }
        }

        protected float Damage()
        {
            throw new System.NotImplementedException();
        }
    }
}