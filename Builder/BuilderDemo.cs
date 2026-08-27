using UnityEngine;

public class BuilderDemo : MonoBehaviour
{
    private void Start()
    {
        EnemyDirector director = new EnemyDirector();
        EnemyBuilder builder = new SkeletonEnemyBuilder();

        Enemy6 enemy = director.Build(builder, Vector3.zero);
        enemy.Print();
    }
}