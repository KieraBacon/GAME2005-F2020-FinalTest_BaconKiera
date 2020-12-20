using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviourAABB : MonoBehaviour
{
    [Header("Bullet Attributes")]
    public float speed;
    public Vector3 direction;
    public float range;

    public BulletManager bulletManager;
    public Vector3 collisionNormal;
    public CubeBehaviour cube;

    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }
    private void _Move()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        if (Vector3.Distance(transform.position, Vector3.zero) > range)
        {
            bulletManager.ReturnBullet(this.gameObject);
        }
    }
}
