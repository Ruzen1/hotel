using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Controlling all the buttons at once
            Button[] btnList = new Button[] { bookingBtn, leftRoomsBtn ,browserBtn,checkInBtn,checkOutBtn,sougouBtn,priceBtn};
            foreach (Button btn in btnList)
            {
                btn.Click += (sender, e) =>
                {
                    foreach (var btn2 in btnList)
                    {
                        btn2.BackColor = ColorTranslator.FromHtml("Black");
                    }
                    btn.BackColor = ColorTranslator.FromHtml("red");
                };
                       
            }
        }
        // for searching the height and width of the panel 2
       
private void ChangeForm(Form f)
{
    f.TopLevel = false;
    splitContainer1.Panel2.Controls.Add(f);
    f.Dock = DockStyle.Fill;
    f.Show();
    f.BringToFront();
            
}

        private void Form1_Shown_1(object sender, EventArgs e)
        {
            Button[] btnList = new Button[] { browserBtn,leftRoomsBtn,priceBtn,bookingBtn,sougouBtn};
            var formList = new Form[] {
                new browser(),
                new leftRooms(),
                new price(),
                new booking(),
                new sougou()
                
            };
            btnList.Zip(formList, (btn, form) => {
                btn.Click += (_, __) => ChangeForm(form);
                return 0;
            }).ToArray();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                browserBtn.PerformClick();
            }
            if (e.KeyCode.ToString() == "F2")
            {
                leftRoomsBtn.PerformClick();
            }
            if (e.KeyCode.ToString() == "F3")
            {
                priceBtn.PerformClick();
            }
            if (e.KeyCode.ToString() == "F4")
            {
                bookingBtn.PerformClick();
            }
            if (e.KeyCode.ToString() == "F5")
            {
                checkInBtn.PerformClick();
            }
            if (e.KeyCode.ToString() == "F6")
            {
                checkOutBtn.PerformClick();
            }
            if (e.KeyCode.ToString() == "F7")
            {
                sougouBtn.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview =true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }
        //    MessageBox.Show(splitContainer1.Panel2.Width.ToString());
        //    MessageBox.Show(splitContainer1.Panel2.Height.ToString());
        //}

    }
}
