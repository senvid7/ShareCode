using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace GenshinImpactMovementSystem
{
    public class GoalIN : MonoBehaviour
    {
        public UnityEvent onTriggerEnter; // 在 Inspector 页面上显示的事件

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                onTriggerEnter.Invoke(); // 触发事件
            }
        }
    }
}
