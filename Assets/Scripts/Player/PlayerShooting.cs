using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint; // where the bullet comes from
    public float fireRate = 0.25f;
    private float nextFireTime = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bulletScript = bullet.GetComponent<Bullet>();
        bulletScript.direction = firePoint.right; // shoot in the direction firePoint is facing
    }
}
