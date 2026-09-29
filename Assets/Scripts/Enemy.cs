using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void ApplyStatus(StatusEffect effect)
    {
        Debug.Log("Enemigo recibe:" +  effect);
    }

    public void ApplyStatus(StatusEffect effect, float duration)
    {
        Debug.Log("Enemigo recibe:" + effect + "Time: " + duration);
    }
}
