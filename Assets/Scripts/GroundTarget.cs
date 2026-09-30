using UnityEngine;

public class GroundTarget : MonoBehaviour
{
    [SerializeField]
    int hp = 1;

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            MissionManager.Instance.OnGroundTargetDestroyed();
            Destroy(gameObject);
        }
    }
}