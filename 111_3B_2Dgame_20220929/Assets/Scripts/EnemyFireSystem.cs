
using UnityEngine;

namespace yo
{
    /// <summary>
    /// 敵人發射系統
    /// </summary>
    public class EnemyFireSystem : FireSystem
    {
        private void Awake()
        {
            SpawnBullet();
        }
    }
}
