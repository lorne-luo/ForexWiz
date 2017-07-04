/*****************************************************************
 * Copyright (C) Leo Studio Corporation. All rights reserved.
 * 
 * Author:   Leo 
 * Email:    luotao.net@gmail.com
 * Website:  http://www.luotao.net
 *
*****************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeoStudio.Autoupdater
{
    public interface IAutoUpdater
    {
        void Update();

        void RollBack();
    }
}
