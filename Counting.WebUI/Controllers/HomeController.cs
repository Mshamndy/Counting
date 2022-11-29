using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Counting.Domain.Abstract;
using Counting.Domain.Entities;
using Counting.Domain.Concrete;
//using System.Threading.Tasks;
//using Microsoft.MixedReality.WebRTC;


namespace Counting.WebUI.Controllers
{
    public class HomeController : Controller
    {
        
        public HomeController()
        {

        }
        public ActionResult Index()

        {
            EFDbContext db = new EFDbContext();
            var Cameras = db.Cameras.ToList();

            return View(Cameras);
        }

        public ActionResult About()
        {

         //   VideoTrackSource webcamSource = null;
         //   Transceiver videoTransceiver = null;
         //   LocalVideoTrack localVideoTrack = null;

         //   var pc = new PeerConnection();

         //var config = new PeerConnectionConfiguration(){
         //           IceServers = new List<IceServer> {
         //   new IceServer{ Urls = { "stun:stun.l.google.com:19302" } }}};
         //  await  pc.InitializeAsync(config);
         //   webcamSource = await DeviceVideoTrackSource.CreateAsync();
         //   var videoTrackConfig = new LocalVideoTrackInitConfig
         //   {
         //       trackName = "webcam_track"
         //   };
         //   localVideoTrack = LocalVideoTrack.CreateFromSource(webcamSource, videoTrackConfig);

         //   videoTransceiver = pc.AddTransceiver(MediaKind.Video);
         //   videoTransceiver.LocalVideoTrack = localVideoTrack;
         //   videoTransceiver.DesiredDirection = Transceiver.Direction.SendReceive;

            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}