using UnityEngine;

namespace yo
{
    /// <summary>
    /// 玩家結束管理: 死亡或通關
    /// </summary>
    public class PlayerFinal : MonoBehaviour
    {
        private void OnDestroy()
        {
            //死亡
            FinalManager.instance.GameOver("遊戲失敗!");
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            //通關
            FinalManager.instance.GameOver("遊戲通關!");
        }
    }
}

