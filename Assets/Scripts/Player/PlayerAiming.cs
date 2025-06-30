using UnityEngine;
using System;

public class PlayerAiming : MonoBehaviour
{
    public Transform firePoint;
    public Transform gunPivot;

    void Update(){
        // Get mouse position in world
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

        // Calculate direction
        Vector2 direction = (mousePos - gunPivot.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Rotate the pivot point
        gunPivot.rotation = Quaternion.Euler(0, 0, angle);

        // Flip gun vertically if aiming backwards
        Vector3 localScale = gunPivot.localScale;
        localScale.y = Mathf.Abs(localScale.y);
        if (angle > 90 || angle < -90){
            localScale.y *= -1;
        }
        gunPivot.localScale = localScale;
    }
}
