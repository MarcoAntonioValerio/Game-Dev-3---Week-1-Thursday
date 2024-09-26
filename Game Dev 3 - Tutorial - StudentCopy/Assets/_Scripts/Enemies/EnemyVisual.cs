using UnityEngine;

public class EnemyVisual : MonoBehaviour
{
    [SerializeField] EnemyData enemyData;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = enemyData.shipVisual;
    }
}
