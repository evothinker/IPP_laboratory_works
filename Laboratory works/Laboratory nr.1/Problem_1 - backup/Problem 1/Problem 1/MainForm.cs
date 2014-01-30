using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Problem_1
{
    public partial class MainForm : Form
    {
        //initialization of our Proxy :)
        //Proxy proxy = new Proxy();

        //initialization of the Cached Proxy
        CachingProxy cProxy = new CachingProxy();

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //proxy.DownloadImage(1, "http://www.publicdomainpictures.net/pictures/20000/nahled/white-labrador-dog-2.jpg", "img1.jpg");
            cProxy.DownloadImage(1, "http://www.publicdomainpictures.net/pictures/20000/nahled/white-labrador-dog-2.jpg", "img1.jpg");
            textBox1.Text += "B1 ";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //proxy.DownloadImage(2, "http://www.temeculacreekinn.com/wp-content/uploads/2012/08/shenandoah_dog.jpg", "img2.jpg");
            cProxy.DownloadImage(2, "http://www.temeculacreekinn.com/wp-content/uploads/2012/08/shenandoah_dog.jpg", "img2.jpg");
            textBox1.Text += "B2 ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //proxy.DownloadImage(3, "http://www.hoax-slayer.com/images/jerky-dog.jpg", "img3.jpg");
            cProxy.DownloadImage(3, "http://www.hoax-slayer.com/images/jerky-dog.jpg", "img3.jpg");
            textBox1.Text += "B3 ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //proxy.DownloadImage(4, "http://static.squarespace.com/static/505cee5be4b0ad7cb8bed420/t/51f21bdbe4b03ff0cf469a8e/1374821340872/panting-dog.jpg", "img4.jpg");
            cProxy.DownloadImage(4, "http://static.squarespace.com/static/505cee5be4b0ad7cb8bed420/t/51f21bdbe4b03ff0cf469a8e/1374821340872/panting-dog.jpg", "img4.jpg");
            textBox1.Text += "B4 ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //proxy.DownloadImage(5, "http://6269-9001.zippykid.netdna-cdn.com/wp-content/uploads/2013/09/Cute-Dog-Wallpaper.jpg", "img5.jpg");
            cProxy.DownloadImage(5, "http://6269-9001.zippykid.netdna-cdn.com/wp-content/uploads/2013/09/Cute-Dog-Wallpaper.jpg", "img5.jpg");
            textBox1.Text += "B5 ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //proxy.DownloadImage(6, "http://stuffkit.com/wp-content/uploads/2012/05/Lovely-dog-wallpaper.jpg", "img6.jpg");
            cProxy.DownloadImage(6, "http://stuffkit.com/wp-content/uploads/2012/05/Lovely-dog-wallpaper.jpg", "img6.jpg");
            textBox1.Text += "B6 ";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
