public class SlimeFactory : EnemySpawner
{
    protected override Enemy4 CreateEnemy()
    {
        return new Slime();
    }
}