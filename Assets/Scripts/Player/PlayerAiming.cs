using UnityEngine;
using System;

public class PlayerAiming : MonoBehaviour
{
    public Transform firePoint;

    // Update is called once per frame
    void Update(){
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePos - transform.position).normalized;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        firePoint.eulerAngles = new Vector3(0, 0, angle);

        Vector3 localScale = firePoint.localScale;
        localScale.y = Mathf.Abs(localScale.y);
        if(angle > 90 || angle < -90){
            localScale.y *= -1;
        }
        firePoint.localScale = localScale;
    }
}
