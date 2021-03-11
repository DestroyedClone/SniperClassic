﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EntityStates.SniperClassicSkills
{
    class ReloadSnipe : BaseReloadState
    {
        public override void SetStats()
        {
            internalBaseDuration = baseDuration;
            internalScaleReloadSpeed = scaleReloadSpeed;
        }
        public static float baseDuration = 0.4f;
        public static bool scaleReloadSpeed = false;
    }
}
