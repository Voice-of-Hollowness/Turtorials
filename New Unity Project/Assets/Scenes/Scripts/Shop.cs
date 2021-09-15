using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scenes.Scripts
{
    class Shop : MonoBehaviour
    {
        public GoodsList Goods;

        private void Start()
        {
            foreach (var good in Goods.Goods)
                Debug.Log(good.name);
        }
    }
}
