using UnityEngine;

public class EnemyVisual : MonoBehaviour
{
    public EnemyData enemyData;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = enemyData.shipVisual;
    }
}
