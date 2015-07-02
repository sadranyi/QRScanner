using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Interop;
using WebCam_Capture;
using ZXing;
using System.Drawing.Imaging;

namespace QRScanner
{
    public partial class Form1 : Form
    {
        private IBarcodeReader _codeReader = new BarcodeReader();
        private WebCamCapture _webcam;
        private PictureBox _imageBox;
        private const int FrameNumber = 30;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            capturedImage.Image = CaptureBox.Image;
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            //SaveCapturedImage(capturedImage.Image);
            var barcodeImage = (Bitmap) capturedImage.Image;
            var code = _codeReader.Decode(barcodeImage);

            if (code != null)
            {
                txtCodeText.Text = code.Text;
            }

        }

        public void InitWebCam(ref PictureBox imageControlBox)
        {
            _webcam = new WebCamCapture();
            _webcam.FrameNumber = ((ulong) (0ul));
            _webcam.TimeToCapture_milliseconds = FrameNumber;
            _webcam.ImageCaptured += new WebCamCapture.WebCamEventHandler(ImageCaptured);
            _imageBox = imageControlBox;
        }

        private void ImageCaptured(object source, WebcamEventArgs e)
        {
            _imageBox.Image = e.WebCamImage;
        }


        public void Start()
        {
            _webcam.TimeToCapture_milliseconds = FrameNumber;
            _webcam.Start(0);
        }

        public void Stop()
        {
            _webcam.Stop();
        }

        public void Continue()
        {
            _webcam.TimeToCapture_milliseconds = FrameNumber;
            _webcam.Start(this._webcam.FrameNumber);
        }

        public void AdvanceSetting()
        {
            _webcam.Config2();
        }


        public static void SaveCapturedImage(Image capturedImage)
        {
            var sav = new SaveFileDialog();
            sav.FileName = "QRCapture";
            sav.DefaultExt = ".Jpg";
            sav.Filter = @"Image (.jpg)|*.jpg";

            if (sav.ShowDialog() == DialogResult.OK)
            {
                var fname = sav.FileName;
                var fstream = new FileStream(fname, FileMode.Create);
                capturedImage.Save(fstream, ImageFormat.Jpeg);
                fstream.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitWebCam(ref CaptureBox);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Continue();
        }
    }
}
