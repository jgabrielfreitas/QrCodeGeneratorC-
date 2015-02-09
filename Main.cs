using QrCode_Generator.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace QrCode_Generator
{
    public partial class QRCode : Form
    {

        public string name;
        public string address;
        public string sale;
        public string cnpj;

        public QRCode()
        {
            InitializeComponent();
        }

        private void QRCode_Load(object sender, EventArgs e)
        {
            Console.WriteLine("=========== INÍCIO DA APLICAÇÃO =============");

            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void generatorStringInConsole(object sender, EventArgs e)
        {
            // get values
            name    = UxTxtMercName.Text;

            //showText.Text = WriteDatas();  <--- show in label

            if (!checkAllFields())
                return;

            IBarcodeWriter writer = new BarcodeWriter 
            { 
                Format  = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions 
                { 
                       Width        = 267,
                       Height       = 267,
                       CharacterSet = "UTF-8",
                       Margin       = 0
                } 
            };

            Image result = writer.Write(WriteDatas());
            var barcodeBitmap        = new Bitmap(result);
            UxPictureBoxQrCode.Image = barcodeBitmap; // create qr code and show

            SaveImage(barcodeBitmap);

        }

        public void SaveImage(Image qrcode)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "(*.jpeg)|*.jpeg";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            DialogResult diagResult  = dialog.ShowDialog();

            if (diagResult == System.Windows.Forms.DialogResult.OK)
            {

                qrcode.Save(dialog.FileName);

            }
     
     
        }

        private void UxPictureBoxQrCode_Click(object sender, EventArgs e)
        {
            // show qr code here ------------------------------------------
        }

        public string WriteDatas()
        {
            Console.WriteLine("nome: " + name);

            string test = "nome: " + name;

            return CacheXML.ReturnCacheXML(name);
        }

        public bool checkAllFields()
        {
            if (UxTxtMercName.Text == null || UxTxtMercName.Text == "") 
            {
                Verifications.Warning("O campo de texto não pode estar vazio");
                return false;
            }
           
            return true;
        }



    }
}