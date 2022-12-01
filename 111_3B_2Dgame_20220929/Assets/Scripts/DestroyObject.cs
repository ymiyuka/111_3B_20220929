using UnityEngine;

namespace yo
{
    /// <summary>
    /// 刪除物件
    /// </summary>
    public class DestroyObject : MonoBehaviour
    {
        [SerializeField, Header("刪除時間"), Range(0, 3)]
        private float destryTime = 0.4f;

        private void Awake()
        {
            //gameObject 此腳本的遊戲物件
            //刪除(物件、刪除時間)
            Destroy(gameObject, destryTime);
        }

        //可見事件 : 當渲染元件 (Randerer) 出現在 Scene 或 Game 時執行一次
        private void OnBecameVisible()
        {
            
        }

        //不可見物件 當渲染物件 (Randerer) 消失在 Scene 或 Game 時執行一次
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}
