using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Counting.Domain.Entities;
using Counting.Domain.Abstract;
using Counting.Domain.Concrete;
using System.Data.Entity;
namespace Counting.WebUI.Controllers
{
    public class AdminController : Controller
    {

        private ICamera repositoryCamera;
        private ILocation repositoryLocation;
        private IProtocol repositoryProtocol;



        public AdminController(ICamera repoCamera, ILocation repoLocation , IProtocol repoProtocol)
        {
            this.repositoryCamera = repoCamera;
            this.repositoryLocation = repoLocation;
            this.repositoryProtocol = repoProtocol;


        }


        // Camera CRUD
        // GET: Admin
        //public ViewResult Index() => View(repositoryCamera.Cameras);
        public ViewResult Index() => View(repositoryCamera.Cameras.ToList());

        public ViewResult Edit(int cameraID) {
            Camera camera = repositoryCamera.Cameras.FirstOrDefault(p => p.CameraID == cameraID);
            ViewBag.LocationID = new SelectList(repositoryLocation.locations, "LocationID", "Name",camera.LocationID);
            ViewBag.ProtocolID = new SelectList(repositoryProtocol.protocols, "ProtocolID", "Name",camera.ProtocolID);


            return View(camera);
              }

        [HttpGet]
        public ActionResult CreateCamera()
        {
            ViewBag.LocationID = new SelectList(repositoryLocation.locations, "LocationID", "Name");
            ViewBag.ProtocolID = new SelectList(repositoryProtocol.protocols, "ProtocolID", "Name");

            return   View("Edit", new Camera());
        }

        [HttpPost]
        public ActionResult Edit(Camera camera)
        {
           
            if (1==1)
            {
                

                repositoryCamera.SaveCameraConf(camera);
                TempData["message"] = $"{camera.Name} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(camera);
            }
        }

        [HttpPost]
        public ActionResult Delete(int cameraID)
        {
            Camera deletedcamera = repositoryCamera.DeleteCamera(cameraID);
            if (deletedcamera != null)
            {
                TempData["message"] = $"{deletedcamera.Name} was deleted";
            }
            return RedirectToAction("Index");
        }


        // Location CRUD

        public ViewResult LocationIndex() => View(repositoryLocation.locations.ToList());

        public ViewResult LocationEdit(int locationID) => View(repositoryLocation.locations.FirstOrDefault(p => p.LocationID == locationID));

        [HttpGet]
        public ActionResult LocationCreate() => View("LocationEdit", new Location());

        [HttpPost]
        public ActionResult LocationEdit(Location location)
        {
            if (1 == 1)
            {
                repositoryLocation.SaveLocation(location);
                TempData["message"] = $"{location.Name} has been saved";
                return RedirectToAction("LocationIndex");
            }
            else
            {
                // there is something wrong with the data values
                return View(location);
            }
        }

        [HttpPost]
        public ActionResult LocationDelete(int locationID)
        {
            Location deletedlocation = repositoryLocation.DeleteLocation(locationID);
            if (deletedlocation != null)
            {
                TempData["message"] = $"{deletedlocation.Name} was deleted";
            }
            return RedirectToAction("LocationIndex");
        }

        // Protocol CRUD

        public ViewResult ProtocolIndex() => View(repositoryProtocol.protocols);
        public ViewResult ProtocolEdit(int protocolID) => View(repositoryProtocol.protocols.FirstOrDefault(p => p.ProtocolID == protocolID));

        [HttpGet]
        public ActionResult ProtocolCreate() => View("ProtocolEdit", new Protocol());

        [HttpPost]
        public ActionResult ProtocolEdit(Protocol protocol)
        {
            if (1 == 1)
            {
                repositoryProtocol.Saveprotocol(protocol);
                TempData["message"] = $"{protocol.Name} has been saved";
                return RedirectToAction("ProtocolIndex");
            }
            else
            {
                // there is something wrong with the data values
                return View(protocol);
            }
        }

        [HttpPost]
        public ActionResult ProtocolDelete(int protocolID)
        {
            Protocol deletedprotocol = repositoryProtocol.DeleteProtocol(protocolID);
            if (deletedprotocol != null)
            {
                TempData["message"] = $"{deletedprotocol.Name} was deleted";
            }
            return RedirectToAction("ProtocolIndex");
        }
    }
}