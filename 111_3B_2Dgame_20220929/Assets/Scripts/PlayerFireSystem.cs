
using UnityEngine;

namespace yo
{
    /// <summary>
    /// 玩家發射系統
    /// </summary>
    public class PlayerFireSystem : FireSystem
    {

        private void Update()
        {
            //如果 玩家按下 空白建 就生成子彈
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }
    }
}
