using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace GenshinImpactMovementSystem
{
    public class GoalIN : MonoBehaviour
    {
        public UnityEvent onTriggerEnter; // �� Inspector ҳ������ʾ���¼�

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                onTriggerEnter.Invoke(); // �����¼�
            }
        }
    }
}
