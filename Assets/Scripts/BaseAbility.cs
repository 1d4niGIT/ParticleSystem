using UnityEngine;
using MoreMountains.Feedbacks;

public abstract class BaseAbility : MonoBehaviour
{
    public Projectile projectilePrefab;

    public Transform firePoint;

    public MMF_Player castFeedback;

    public abstract void Execute();

    protected virtual void PlayFeedback()
    {
        castFeedback.PlayFeedbacks();
    }

    protected void Shoot (float speed, StatusEffect effect, float duration)
    {
        Projectile projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);

        projectile.speed = speed;
        projectile.duration = duration;
        projectile.effect = effect;
    }
}
