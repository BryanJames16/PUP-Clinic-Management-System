using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

using QRCoder;

namespace ClinicManagementSystem
{
    class QuickRead
    {
        public static Bitmap GenerateQR(string data)
        {
            Bitmap result = null;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            result = qrCode.GetGraphic(72);

            return (result);
        }
    }
}
