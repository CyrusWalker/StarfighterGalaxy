using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShootContinuous : MonoBehaviour, IUpdateSelectedHandler, IPointerDownHandler, IPointerUpHandler
    {
        private bool isPressed;
        private float timer;
        [SerializeField] private float timerMax = 1f;
        [SerializeField] private Weapon1 weapon;

        public void OnUpdateSelected(BaseEventData data)
        {
            if (isPressed && timer <= 0)
            {
                weapon.Shoot();
                timer = timerMax;
            }
        }

        private void Update()
        {
            timer -= Time.deltaTime;
        }

        public void OnPointerDown(PointerEventData data)
        {
            isPressed = true;
        }
        
        public void OnPointerUp(PointerEventData data)
        {
            isPressed = false;
        }

        public void SetFireRate(float secondsPerShot) {
            timerMax = secondsPerShot;
        }
    
    }
