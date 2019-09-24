using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_SPRING_2019
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void mycontainer1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mycontainer1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }

    public class Mycontainer : Panel
    {
        PictureBox pic;
        Button dj;
        Button ej;
        Button fj;
        TextBox vlu;


       

        public Mycontainer()
        {
            dj = new Button();
            dj.Text = "Open";
            dj.Top = 500;
            dj.Height = 35;
            dj.Left = 280;
            dj.Click += new EventHandler(dj_Click);

            Timer n = new Timer();

            Button ej = new Button();
            ej.Text = "<-------";
            ej.Top = 500;
            ej.Height = 35;

            ej.Click += new EventHandler(ej_Click_1);


            Button fj = new Button();
            fj.Text = "------->";
            fj.Top = 500;
            fj.Height = 35;
            fj.Left = 500;
            fj.Click += new EventHandler(fj_Click_1);


             vlu = new TextBox();
            vlu.Text = "";
            vlu.Top = 550;
            vlu.Left = 280;
            vlu.Click += new EventHandler(vlu_Click_1);


          pic = new PictureBox();
            pic.Left = 100;
            pic.Top = 100;
            pic.Height = 400;
            pic.Width = 700;
            pic.Click += new EventHandler(pic_Click_1);


           Label tyt = new Label();
            tyt.Text = "Gallery View";
            tyt.Left = 280;
            tyt.Font = new System.Drawing.Font("Monospac821 BT", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


            this.Controls.Add(dj);
            this.Controls.Add(ej);
            this.Controls.Add(fj);
            this.Controls.Add(vlu);
            this.Controls.Add(pic);
            this.Controls.Add(tyt);

           





        }
        private void dj_Click(object sender, EventArgs e)
        {
            try
            {
                String OpenAddres = vlu.Text;

                Bitmap pok = new Bitmap(OpenAddres);
                int width = pok.Width;
                int heigth = pok.Height;
                pic.Image = Image.FromFile(OpenAddres);
            }
            catch (Exception en)
            {

                Console.WriteLine("Sahi address Nahi h");
            }
           
               

            
        }
        private int imagenumber = 1;
        private void loadNextImage()
        {

            if (imagenumber >= 1)
            {
                imagenumber++;
                pic.ImageLocation = string.Format(@"D:\\images\\{0}.jpg", imagenumber);



            }



        }
        private int BackImage = 10;
        private void BackImages()
        {
            if (imagenumber >= 10)
            {
                BackImage--;
                pic.ImageLocation = string.Format(@"D:\\images\\{0}.jpg", BackImage);



            }
        }

        private void fj_Click_1(object sender, EventArgs e)
        {
            loadNextImage();

        }
        private void ej_Click_1(object sender, EventArgs e)
        {
            BackImages();
        }
        private void pic_Click_1(object sender, EventArgs e)
        {

            imagenumber = 10;
            pic.ImageLocation = string.Format(@"D:\\Images\\{0}.jpg", imagenumber);


            loadNextImage();



        }
        private void vlu_Click_1(object sender, EventArgs e)
        {
            

        }
        private void ij_Click_1(object sender, EventArgs e)
        {
            

        }


    }
}
