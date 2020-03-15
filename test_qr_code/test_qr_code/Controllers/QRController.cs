﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using test_qr_code.EF;

namespace test_qr_code.Controllers
{
    public class QRController : Controller
    {
        private readonly MyContext db;

        public QRController(MyContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("www.google.com", QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            var bitmapBytes = BitmapToBytes(qrCodeImage); //Convert bitmap into a byte array
            return File(bitmapBytes, "image/jpeg"); //Return as file result
        }
        // This method is for converting bitmap into a byte array
        private static byte[] BitmapToBytes(Bitmap img)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
    }
}