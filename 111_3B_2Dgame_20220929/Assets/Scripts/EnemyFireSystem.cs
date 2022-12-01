﻿
using UnityEngine;

namespace yo
{
    /// <summary>
    /// 敵人發射系統
    /// </summary>
    public class EnemyFireSystem : FireSystem
    {
        [SerializeField, Header("生成子彈時間"), Range(0, 3)]
        private float interval = 1.5f;

        private void Awake()
        {
            //呼叫方法
            //SpawnBullet();


        }

        private void OnBecameVisible()
        {
            //延遲重複呼叫("方法名稱"，延遲時間，重複頻率)
            InvokeRepeating("SpawnBullet", 0, interval);
        }

        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}
