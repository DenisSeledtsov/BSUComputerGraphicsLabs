using Kaitai;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagesReader
{
    public partial class Form1 : Form
    {
        struct ImageInfo
        {
            public string name;
            public string depth;
            public string compression;

            public int width;
            public int heigth;
            public int resolution;
        }

        string[] files;
        string basePath;

        BlockingCollection<ImageInfo> images;
        static object locker = new object();

        public Form1()
        {
            InitializeComponent();
            images = new BlockingCollection<ImageInfo>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void GetDate(FileInfo f)
        {
            int imageWidth;
            int imageHeigth;
            int resolution;

            string imageDepth;
            string compressionType;
            Bitmap bitmap;

            Int16 bitConv = -1;

            if (f.Extension != ".pcx")
            {
                bitmap = new Bitmap(f.FullName);
                imageWidth = bitmap.Width;
                imageHeigth = bitmap.Height;
                resolution = Convert.ToInt32(bitmap.HorizontalResolution);
                imageDepth = bitmap.PixelFormat.ToString();

                int compressionTagIndex = Array.IndexOf(bitmap.PropertyIdList, 0x103);
                if (compressionTagIndex >= 0)
                {
                    PropertyItem compressionTag = bitmap.PropertyItems[compressionTagIndex];
                    bitConv = BitConverter.ToInt16(compressionTag.Value, 0);
                    if (bitConv < 0)
                        bitConv += Int16.MaxValue - 1;
                }
                bitmap.Dispose();

                if (bitConv == 2)
                    compressionType = "Rle";
                else if (bitConv == 3)
                    compressionType = "Fax 3";
                else if (bitConv == 4)
                    compressionType = "Fax 4";
                else if (bitConv == 5)
                    compressionType = "Lzw";
                else
                    compressionType = "Undefined";
            }
            else
            {
                var dataPcx = Pcx.FromFile(f.FullName);
                imageWidth = dataPcx.Hdr.ImgXMax;
                imageHeigth = dataPcx.Hdr.ImgYMax;
                resolution = dataPcx.Hdr.Hdpi;
                imageDepth = dataPcx.Hdr.BitsPerPixel.ToString();
                compressionType = dataPcx.Hdr.Encoding.ToString();
            }

            if (f.Extension == ".png")
                compressionType = "Deflate";

            if (f.Extension == ".gif")
                compressionType = "Lzw";

            if (f.Extension == ".jpg")
                compressionType = "Jpeg";

            ImageInfo imageInfo = new ImageInfo();
            imageInfo.name = f.Name;
            imageInfo.width = imageWidth;
            imageInfo.heigth = imageHeigth;
            imageInfo.depth = imageDepth;
            imageInfo.resolution = resolution;
            imageInfo.compression = compressionType;

            images.Add(imageInfo);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog.Description = "Choose your folder with images";
            folderBrowserDialog.ShowNewFolderButton = false;

            label1.Text = "Loading a lot of files can take a few seconds...";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                basePath = folderBrowserDialog.SelectedPath;
                textBox1.Text = basePath;
                files = Directory.GetFiles(basePath);

                Stopwatch sw = new Stopwatch();
                sw.Start();

                int counter = 0;
                FileInfo fileInfo;
                Parallel.For(0, files.Length, x =>
                {
                    lock (locker)
                    {
                        fileInfo = new FileInfo(files[counter]);
                        counter++;
                    }
                    GetDate(fileInfo);
                });

                sw.Stop();
                label1.Text = "Files loading was complited (" + files.Length + " images, " + sw.ElapsedMilliseconds / 1000.0f + " seconds)";

                ImageInfo imageInfo = new ImageInfo();
                for (int i = 0; i < files.Length; i++)
                {
                    imageInfo = images.Take();
                    dataGridView1.Rows.Add(imageInfo.name, imageInfo.width + "*" + imageInfo.heigth, imageInfo.resolution,
                        imageInfo.depth, imageInfo.compression);
                }
            }
        }
    }
}
