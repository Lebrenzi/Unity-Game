﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    using UnityEngine;
    using System.Collections;

    public class Touch : MonoBehaviour
    {
        private Controls player;

        void Start()
        {
            player = FindObjectOfType<Controls>();
        }

        public void LeftArrow()
        {
            player.moveright = false;
            player.moveleft = true;
        }
        public void Jump()
        {
            player.jump = true;
        }
        public void RightArrow()
        {
            player.moveright = true;
            player.moveleft = false;
        }
        public void ReleaseLeftArrow()
        {
            player.moveleft = false;
        }
        public void ReleaseRightArrow()
        {
            player.moveright = false;

        }

    }
}
