using UnityEngine;

namespace yo
{
    /// <summary>
    /// 傷害系統
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("爆炸預製物")]
        private GameObject prefabExplosion;
        [SerializeField, Header("碰到會爆炸的名稱")]
        private string nameTarget;

        //碰撞開始時執行一次
        private void OnCollisionEnter2D(Collision2D collision)
        {
            print(collision.gameObject.name);

            //如果 碰到的物品名稱 包含 nameTarget 就爆炸並刪除
            if (collision.gameObject.name.Contains(nameTarget))
            {
                // 生成爆炸預製物 座標與角度 跟此物品相同
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                // 刪除 Destroy
                // 此物件 gameObject
                Destroy(gameObject);
            }
        }
        //碰撞離開時執行一次
        private void OnTriggerExit2D(Collider2D collision)
        {
            
        }
        //碰撞持續執行
        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
    }
}
