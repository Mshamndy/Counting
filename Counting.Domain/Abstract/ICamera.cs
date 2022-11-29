using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Counting.Domain.Entities;

namespace Counting.Domain.Abstract
{
   public interface ICamera
    {
        IEnumerable<Camera> Cameras { get; }
        void SaveCameraConf(Camera cameraconf);
        Camera DeleteCamera(int CameraID);
    }
}
