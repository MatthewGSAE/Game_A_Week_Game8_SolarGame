using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;

    public float speed = 70f;
    public GameObject impactEffect;

    public void Seek(Transform _target)
    {
        target = _target;
    }

    private void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        // if the bullet is about to move this next frame and overshoot the target
        // it will just call that it has hit the target
        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate (dir.normalized * distanceThisFrame, Space.World);
    }

    void HitTarget()
    {
        GameObject effectInd = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectInd, 2f);

        Destroy(target.gameObject);

        Destroy(gameObject);
    }
}
