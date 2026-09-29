using UnityEngine;

public class FireAbility : BaseAbility
{
    public override void Execute()
    {
       Shoot(10, StatusEffect.Burn, 3f);
       PlayFeedback();
    }
}
