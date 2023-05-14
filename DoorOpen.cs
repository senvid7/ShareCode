using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenshinImpactMovementSystem
{
    public class DoorOpen : MonoBehaviour
    {
        // Start is called before the first frame update
        public float openSpeed = 2f;
        public float openDistance = 2f;
        public bool isOpen = false;

        private Transform leftDoor;
        private Transform rightDoor;
        private Vector3 leftClosedPos;
        private Vector3 rightClosedPos;
        private Vector3 leftOpenPos;
        private Vector3 rightOpenPos;

        void Start()
        {
            leftDoor = transform.Find("Left");
            if (leftDoor == null)
            {
                Debug.LogWarning("Cannot find LeftDoor child object!");
                return;
            }

            rightDoor = transform.Find("Right");
            if (rightDoor == null)
            {
                Debug.LogWarning("Cannot find RightDoor child object!");
                return;
            }

            leftClosedPos = leftDoor.localPosition;
            rightClosedPos = rightDoor.localPosition;
            leftOpenPos = leftClosedPos + Vector3.forward * openDistance;
            rightOpenPos = rightClosedPos + Vector3.back * openDistance;
        }

        public void OpenHorizontal()
        {
            if (!isOpen)
            {
                isOpen = true;
                StartCoroutine(OpenHorizontalCoroutine());
            }
        }

        IEnumerator OpenHorizontalCoroutine()
        {
            if (leftDoor == null || rightDoor == null)
            {
                Debug.LogWarning("LeftDoor or RightDoor not found!");
                yield break;
            }

            float t = 0f;
            while (t < 1f)
            {
                t += Time.deltaTime * openSpeed;
                leftDoor.localPosition = Vector3.Lerp(leftClosedPos, leftOpenPos, t);
                rightDoor.localPosition = Vector3.Lerp(rightClosedPos, rightOpenPos, t);
                yield return null;
            }
        }
    }
}