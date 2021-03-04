using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern_Demo
{
    class SamsungPhoneBridge : BasePhone
    {
        public override void Call()
        {
            Console.WriteLine($"{this.GetType().Name}构建 操作系统：{base.CurrentSystem.SystemName()}版本号：{base.CurrentSystem.VersionNo()} 开始打电话"); 
        }

        public override void Text()
        {
            Console.WriteLine($"{this.GetType().Name}构建 操作系统：{base.CurrentSystem.SystemName()}版本号：{base.CurrentSystem.VersionNo()} 开始发短信");
        }
    }
}
