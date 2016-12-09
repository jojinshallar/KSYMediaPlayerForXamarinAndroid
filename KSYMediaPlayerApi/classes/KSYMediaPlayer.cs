using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ksyun.Media.Player
{
    public partial class KSYMediaPlayer
    {
        public override Com.Ksyun.Media.Player.Misc.PM_DInterface[] GetTrackInfo()
        {
            return this.GetMediaPlayerTrackInfo();
        }
    }
}
