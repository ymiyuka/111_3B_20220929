
using UnityEngine;

namespace yo
{
    /// <summary>
    /// 發射系統基底
    /// </summary>
    public class FireSystem : MonoBehaviour
    {
        [SerializeField,Header("子彈預製物")]
        private GameObject prefaBullet;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawn;
        [SerializeField, Header("發射音效")]
        private AudioClip soundFire;

        // 自訂方法
        // 生成子彈
        // 保護級別 : 允許子類別存取
        protected void SpawnBullet()
        {
            // 實例化(子彈生成點，座標、角度)
            // 生成 子彈預製物 座標與角度跟生成點相同
            Instantiate(prefaBullet, pointSpawn.position, pointSpawn.rotation);

            SoundManager.instance.PlaySound(soundFire, new Vector2(0.7f, 1.2f));
        }

    }
}
