
using UnityEngine;

namespace yo
{
    /// <summary>
    /// ���a�o�g�t��
    /// </summary>
    public class PlayerFireSystem : FireSystem
    {

        private void Update()
        {
            //�p�G ���a���U �ťի� �N�ͦ��l�u
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }
    }
}
